using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод первого числа
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //ввод второго числа
            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //ввод операции
            Console.WriteLine("Enter operation(+, -, *, /, >, <)");

            string conv = Console.ReadLine();
            //Console.WriteLine(conv);

            //выполнение операций
            if (conv.Equals("+")) //сложение
            {
                Console.Write(num1 + num2);
            }
            else if (conv.Equals("-")) //вычитание
            {
                Console.Write(num1 - num2);
            }
            else if (conv.Equals("*")) //умножение
            {
                Console.Write(num1 * num2);
            }
            else if (conv.Equals("/")) //деление
            {
                Console.Write(num1 / num2);
            }
            else if (conv.Equals(">")) //найти наибольшее число
            {
                if (num1 > num2)

                {
                    Console.Write(num1);
                }

                else
                {
                    Console.Write(num2);
                }
            }

            else if (conv.Equals("<")) //найти наименьшее число
            {
                if (num1 < num2)

                {
                    Console.Write(num1);
                }

                else
                {
                    Console.Write(num2);
                }
            }
            else
            {
                Console.Write("Invalid operation");
            }

        }
    }
}