using System;

class Calculator 
{
    static void Regul_calc() 
    {
        try
        {
            Console.WriteLine("ВВедите число, знак и второе число." + 
                                "\nЕсли хотите выйти - exit");
            string x1 = Console.ReadLine(), znak = Console.ReadLine(), 
                        y1 = Console.ReadLine();
            if (x1 == "exit") 
            {
                Menu();
            }  
            double x = Convert.ToDouble(x1), y = Convert.ToDouble(y1);
            switch (znak) 
            {
                case "+":
                    Console.WriteLine($"Результат: {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {x * y}");
                    break;
                case "/":
                    Console.WriteLine($"Результат: {x / y}");
                    break;
                case "%":
                    Console.WriteLine($"Результат: {x % y}");
                    break;
                default:
                    Console.WriteLine("Абшибка! Выбрана неверная аперацыя или некаректный ввод!");
                    break; 
            }
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine($"Абшибка Вичисления! ({e})");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Абшибка ВВода! ({e})");
        }
        finally
        {
            Regul_calc();
        }
    }

    static void Eng_calc()
    {

    }

    static void FizzBuzz()
    {
        try
        {
            Console.WriteLine("Число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++) 
            {
                if (number % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Абшибка! ({e})");
        }
    }
    
    static void Menu() 
    {
        try
        {
            Console.Write("Что вам нужно? Обичний (1) или инженерний (2) калькулятор, FizzBuzz (3)?: ");
            int type_of_calc = Convert.ToInt16(Console.ReadLine());
            switch (type_of_calc) 
            {
                case 1:
                    Regul_calc();
                    break;
                case 2:
                    Eng_calc();
                    break;
                case 3:
                    FizzBuzz();
                    break;
                default:
                    Console.WriteLine("Абшибка! Вибрана неверная аперацыя или некаректный ввод!");   
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Абшибка! ({e})");
        }
        finally
        {
            Menu();
        }
    }

    static void Main(string[] args) 
    {
        Menu();
    }
}