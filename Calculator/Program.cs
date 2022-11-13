using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Usereingabe:
Was soll verrechnet werden
Welche Rechneoperation

Funktionen
Addition
Subrtation
Multiplikation
Division
Quadrieren
Wurzel
*/

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chooseOperation;

            Console.WriteLine("Which calculation do you need?");
            Console.WriteLine("1=Addition \n2=Subtraktion \n3=Multiplication \n4=Division \n5=Square \n6=Squareroot");
            chooseOperation = Convert.ToInt32(Console.ReadLine());
            switch (chooseOperation)
            {
                    case 1:
                    Addition(1, 2);
                    break;
                    case 2:
                    Subtraction(1, 2);
                    break;      
                    case 3:
                    Multiplication(1, 2);
                    break;
                    case 4:
                    Divide(1, 2);
                    break;
                    case 5:
                    Square(1, 2);
                    break;
                    case 6:
                    SquareRoot(1,2);  
                    break;
            }
            Console.WriteLine(Addition(1, 2));
            Console.ReadLine();
        }

        static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        static double Square(double number1, double number2)
        {
            return number1 * number2;
        }

        //wie kann nur der erste parameter übergeben werden?
        static double SquareRoot(double number1, double number2)
        {
            return Math.Sqrt(number1);
        }
    }
}
