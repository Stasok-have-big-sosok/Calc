using System;

class Metal_Calc 
{
    static void Sheet()
    {
        Console.WriteLine("Введите длину, ширину и толщину листа, " + 
                        "а также плотность металла в его составе (г/см^3)");
        Console.WriteLine("В меню - exit");
        string leng1 = Console.ReadLine();
        if (leng1 == "exit")
        {
            Menu();
        }
        double leng = Convert.ToDouble(leng1),
                wid = Convert.ToDouble(Console.ReadLine()), 
                thick = Convert.ToDouble(Console.ReadLine()), 
                dens = Convert.ToDouble(Console.ReadLine());
        double masa = dens * leng * wid * thick / 1000000;
        Console.WriteLine($"Маса = {masa} кг");
    }
    
    static void Menu()
    {
        Console.Write("Лист,");
        string product = Console.ReadLine();
        switch (product) 
        {
            case "Лист":
                Sheet();
                break;
            default:
                Console.WriteLine("Абшибка! Вибрана неверная операция");
                break;
        }
    }
    
    static void main(string[] args) 
    {
        Menu();
    }
}