using System;
using System.Security.Cryptography;

namespace Игра
{
    internal class Program
    {
        public static int Delitelb { get; private set; }

        static void Main()
        {
            Console.WriteLine("Для работы программы введите число программы из списка: ");
            Console.WriteLine("1.Угадай число");
            Console.WriteLine("2.Таблица умножения");
            Console.WriteLine("3.Вывод делителей числа");
            Console.WriteLine("4.Выйти из программы");
            int Chislo = Convert.ToInt32(Console.ReadLine());
            
            if (Chislo == 1)
            {
                UgadaiChislo();
            }
            else if (Chislo == 2)
            {
                TablisaYmnozhenia();
            }
            else if (Chislo == 3)
            {
                VivodDeliteleiChisla();
            }
            else if (Chislo == 4)
            {
                Console.WriteLine("Программа завершена");
            }
            else
                Console.WriteLine("Вы ввели неправильное число");

        }
        static void UgadaiChislo()
        {

            Random rand = new Random();
            int Pravchislo = rand.Next(100) + 1;

            do
            {
                Console.WriteLine("Введите число: ");
                int ChisloGuess = Convert.ToInt32(Console.ReadLine());
                if (ChisloGuess == Pravchislo)
                {
                    Console.WriteLine("Успешно угадали");
                    break;
                }
                else
                {
                    if (ChisloGuess > Pravchislo)
                    {
                        Console.WriteLine("Число меньше загаданного");


                    }
                    else
                    {

                        Console.WriteLine("Число больше загаданного");

                    }
                    
                }


            } while (true);
            Main();
        }

    
        static void TablisaYmnozhenia()
        {
            int[,] massiv = new int[10, 10];
            for (int stroka = 1; stroka < massiv.GetLength(0); ++stroka)
            {
                for (int stolbiki = 1; stolbiki < massiv.GetLength(1); ++stolbiki)
                {

                    int sum = stroka * stolbiki;
                    if (stroka == stolbiki)
                    {
                        massiv[stroka, stolbiki] = sum;
                        Console.Write(massiv[stroka, stolbiki] + "\t");
                    }
                    else if (stroka > stolbiki)
                    {
                        massiv[stroka, stolbiki] = sum;
                        Console.Write(massiv[stroka, stolbiki] + "\t");
                    }
                    else if (stroka < stolbiki)
                    {
                        massiv[stroka, stolbiki] = sum;
                        Console.Write(massiv[stroka, stolbiki] + "\t");
                    }
                    

                }
                Console.WriteLine("\n\n");
                
            }
            Main();
        }

        static void VivodDeliteleiChisla()
        {

            string Povtor = "yes";

            do
            {
                Console.Write("Введите число: ");
                int delimoe = Convert.ToInt32(Console.ReadLine());
                for (Delitelb = 1; Delitelb <= delimoe; Delitelb++)
                {
                    if (delimoe % Delitelb == 0)
                    {
                        Console.WriteLine(Delitelb + "\n");
                    }
                }
                Console.WriteLine("Хотите продолжить? (yes/no)");
                Povtor = Convert.ToString(Console.ReadLine());

            } while (Povtor == "yes");

            
            Main();
            
        } 
       

    }
}