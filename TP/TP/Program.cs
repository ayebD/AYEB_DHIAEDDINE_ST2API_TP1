using System;
using System.Collections.Generic;

namespace TP
{
    class Program
    {
       //J'ai mit en commentaire le main il suffira seulement d'enlever les commentaire pour chaque fonction et exos
        static void Main(string[] args)
        {
            //Tree(10);
            //Square(5, 1);
            //Square2(10, 10);

            //Table de multiplication 
            /*for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }*/

            //Table de multiplication mais seulement odd result
            /*for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if((i*j) % 2 != 0)
                    {
                        Console.Write(i * j + "\t");

                    }
                    else Console.Write("\t");
                }
                Console.Write("\n");
            }*/

            //Table de multiplication mais que de N
            /*int number = AskUserForParameter();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * number + "\t");
            }*/

            //Prime();
            /*int x = AskUserForParameter();
            F(x);*/

            //Console.WriteLine(Factorial(4));

            //Exercice try catch
            /*try
            {
                float x = PowerFunction(10);
                Console.Write(10 / x);

            }
            catch (Exception e)
            {
                Console.WriteLine("Devide by zero impossible.", e);
            }*/


        }


        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static void Tree(int taille)
        {
            
                for (int i = 0; i < taille; i++)
                {
                    for (int v = 0; v < taille - i; v++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 2 * i + 1; j++)
                    {

                        Console.Write('*');
                    }
                    Console.Write('\n');
                }
                Console.Write(new string(' ', taille - 1) + "| |");
            
        }

        public static void Tree2(int taille)
        {

            for (int i = 0; i < taille; i++)
            {
                for (int v = 0; v < taille - i; v++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {

                    Console.Write('*');
                }
                Console.Write('\n');
            }
            Console.Write(new string(' ', taille - 1) + "| |");

        }


        public static void Square(int n, int m) 
        {

            Console.Write("0");
            for (int i = 1; i < m - 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("0");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");

                for (int j = 0; j < m - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("|");
            }

            Console.Write("0");
            for (int i = 1; i < m - 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("0");

        }

        public static void Square2(int n, int m)
        {

            Console.Write("0");
            for (int i = 1; i < m - 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("0");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");

                for (int j = 0; j < m - 2; j++)
                {
                    if (j%3 == 0) Console.Write("*");
                    else  Console.Write(" ");
                }

                Console.WriteLine("|");
            }

            Console.Write("0");
            for (int i = 1; i < m - 1; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("0");

        }

        public static void Prime()
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
        }

        public static void F(int x)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            while (num1 <= x)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(num2);
            }
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
            //c: It will result of an error because of the memory limitation
            //d: a recusive function is a function which call it self
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

    }
}

  