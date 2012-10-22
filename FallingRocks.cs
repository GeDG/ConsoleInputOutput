using System;
using System.Threading;
using System.Collections.Generic;


public class Dwarf 
    {
        public int x;
        public int y;
        public Dwarf(int x, int y) 
        {
            this.x = x;
            this.y = y;
            WriteDwarf();
        }
        public void WriteDwarf()
        {
            Console.SetCursorPosition(x, y);
            Console.Write('O');
            Console.SetCursorPosition(x - 1, y);
            Console.Write('(');
            Console.SetCursorPosition(x + 1, y);
            Console.Write(')');        
        }
        public void DelDwarf() 
        {
            Console.SetCursorPosition(x + 1, y);
            Console.Write(' ');
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
            Console.SetCursorPosition(x - 1, y);
            Console.Write(' ');
        }
    }

public class Rocks 
    {
        public int x;
        public int y;
        public char rockSymbol;
        public ConsoleColor Color;
        public Rocks(int x,int y,char symbol,ConsoleColor color)
        {
            this.x = x;
            this.y = y;
            this.rockSymbol = symbol;
            this.Color = color;
            WriteRock();
        }
        public void WriteRock() 
        {
            Console.SetCursorPosition(x,y);
            Console.ForegroundColor = Color;
            Console.Write(rockSymbol);
            Console.ResetColor();            
        }
    }

class FallingRocks
{
    static void Main()
    {
        Console.CursorVisible = false;
        Console.WindowHeight = 30;
        Console.WindowWidth = 60;
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;


        Random randomGenerator = new Random(DateTime.Now.Millisecond);

        double sleepTime = 101;
        double allScore = 0;
        bool gameOver = false;

        List<Rocks> allRocks = new List<Rocks>();
        List<Rocks> Remove = new List<Rocks>();
        Dwarf dwarf = new Dwarf(Console.WindowWidth / 2, Console.WindowHeight - 1);
     
        while(true)
        {
         char rockSymbol=' ';
         int randomSymbol = randomGenerator.Next(0,12);
            switch(randomSymbol)
                {
                    case 0: rockSymbol = '^'; break;
                    case 1: rockSymbol = '@'; break;
                    case 2: rockSymbol = '*'; break;
                    case 3: rockSymbol = '&'; break;
                    case 4: rockSymbol = '+'; break;
                    case 5: rockSymbol = '%'; break;
                    case 6: rockSymbol = '$'; break;
                    case 7: rockSymbol = '#'; break;
                    case 8: rockSymbol = '!'; break;
                    case 9: rockSymbol = '.'; break;
                    case 10: rockSymbol = ';'; break;
                    case 11: rockSymbol = '-'; break;
                    default: Console.Write("Error!"); break;
                }

                ConsoleColor[] colors =
                {
                     ConsoleColor.Yellow,
                     ConsoleColor.DarkGreen,
                     ConsoleColor.DarkCyan,
                     ConsoleColor.Green,
                     ConsoleColor.DarkBlue,
                     ConsoleColor.Magenta,
                     ConsoleColor.White,
                     ConsoleColor.DarkRed,
                     ConsoleColor.DarkGray
                };
                
            int iColor = randomGenerator.Next(0, 9);
            int xRock = randomGenerator.Next(0, 59);
            allRocks.Add(new Rocks(xRock, 0, rockSymbol, colors[iColor]));

             foreach (Rocks rock in allRocks)
             {
                 Console.SetCursorPosition(rock.x, rock.y);
                 Console.Write(' ');
                 if (rock.y < Console.WindowHeight - 1)
                 {

                     rock.y++;
                     if (rock.y == Console.WindowHeight - 1 && (rock.x == dwarf.x || rock.x == dwarf.x - 1 || rock.x == dwarf.x + 1) && !gameOver)
                     {
                         gameOver = true;
                     }
                     rock.WriteRock();
                 }
                 else 
                 {
                     Remove.Add(rock);      
                 }
                 

             }

             foreach (Rocks rock in Remove) 
             {
                 allRocks.Remove(rock);
             }

            while (Console.KeyAvailable) 
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow && dwarf.x > 1) 
                {
                    dwarf.DelDwarf();
                    dwarf.x -= 1;
                    dwarf.WriteDwarf();
                    foreach (Rocks rock in allRocks) 
                    {
                        if (rock.y == Console.WindowHeight - 1 && (rock.x == dwarf.x || rock.x == dwarf.x - 1 || rock.x == dwarf.x + 1))
                        {
                            gameOver = true;
                            rock.WriteRock();
                            break;
                        }
                    }

                    if (gameOver)break;          

                }
                else if (key.Key == ConsoleKey.RightArrow && dwarf.x < Console.WindowWidth - 3)
                {
                    dwarf.DelDwarf();
                    dwarf.x += 1;
                    dwarf.WriteDwarf();
                    foreach (Rocks rock in allRocks)
                    {
                        if (rock.y == Console.WindowHeight - 1 && (rock.x == dwarf.x || rock.x == dwarf.x - 1 || rock.x == dwarf.x + 1))
                        {
                            gameOver = true;
                            rock.WriteRock();
                        }
                    }

                    if (gameOver)break;
                }
            }


            if (!gameOver)
            {
                allScore += DateTime.Now.Second;
            }
            else
            {
                Console.Title = "YOUR SCORE = " + allScore.ToString();
                break;
            }
        
            Thread.Sleep((int)sleepTime);
            sleepTime -= 0.02;
         
        }
        Console.BufferHeight += 1;
        Console.WindowWidth += 1;
        Console.SetCursorPosition(0, Console.WindowHeight);
        Console.WriteLine("YOUR SCORE = " + allScore.ToString() + " TRY AGAIN ");
    }
}

