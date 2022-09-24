using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);
            string Vvod = Console.ReadLine();
            int Razmer = Vvod.Length;
            int SizeX = Razmer * 11;
            int SizeY = 5;
            var x = (Console.WindowWidth / 2) - (SizeX / 2);
            var y = (Console.WindowHeight / 2) - (SizeY / 2);
            foreach (char c in Vvod)
            {
                switch (c)
                {
                    case ('0'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■', ' ', '■',' ', '■', ' ', '■', ' ', '■',' ', ' '},
                            {'■', ' ', ' ',' ', ' ', ' ', ' ', ' ', '■',' ', ' '},
                            {'■', ' ', ' ',' ', ' ', ' ', ' ', ' ', '■',' ', ' '},
                            {'■', ' ', ' ',' ', ' ', ' ', ' ', ' ', '■',' ', ' '},
                            {'■', ' ', '■',' ', '■', ' ', '■', ' ', '■',' ', ' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;
                    case ('1'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■', ' ', '■',' ', '■', ' ', ' ', ' ', ' ',' ',' '},
                            {' ', ' ', ' ',' ', '■', ' ', ' ', ' ', ' ',' ',' '},
                            {' ', ' ', ' ',' ', '■', ' ', ' ', ' ', ' ',' ', ' '},
                            {' ', ' ', ' ',' ', '■', ' ', ' ', ' ', ' ',' ', ' '},
                            {'■', ' ', '■',' ', '■', ' ', '■', ' ', '■',' ', ' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;

                    case ('2'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {' ', ' ',' ', ' ',' ',' ',' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ' ,'■',' ',' '},
                            {'■', ' ',' ',' ',' ',' ',' ', ' ', ' ',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;
                    case ('3'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {' ',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ',' ', ' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;

                    case ('4'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;
                    case ('5'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', ' ',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;
                    case ('6'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ' ,'■',' ','■',' ', '■',' ', '■',' ',' '},
                            {'■',' ', ' ',' ', ' ', ' ',' ',' ',' ',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;
                    case ('7'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;
                    case ('8'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break;
                    case ('9'):
                        {
                            int Dop = x;
                            char[,] Cifra =
                            {
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {'■',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '},
                            {' ',' ', ' ',' ',' ',' ', ' ',' ', '■',' ',' '},
                            {'■',' ', '■',' ','■',' ', '■',' ', '■',' ',' '}
                        };
                            for (int i = 0; i < 5; i++, ++y, x = Dop)
                            {
                                for (int j = 0; j < 11; j++, ++x)
                                {

                                    Console.SetCursorPosition(x, y);
                                    Console.Write(Cifra[i, j]);
                                }
                            }
                            x += 11;
                            y = (Console.WindowHeight / 2) - (SizeY / 2);
                        }
                        break; 
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n\n");
        }
    }
}

