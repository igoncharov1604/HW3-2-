using System;

class Miscevist
{
    public double Ploshcha { get; set; }
    public int Naselennia { get; set; }
    public string Relyef { get; set; }

    // Перевизначений метод №1 (2 параметри)
    public void ObchyslytyShylnist(double ploshcha, int naselennia)
    {
        if (ploshcha > 0)
        {
            double shylnist = naselennia / ploshcha;
            Console.WriteLine($"Щільність населення: {shylnist} осіб на км²");
        }
        else
        {
            Console.WriteLine("Площа має бути більшою за 0.");
        }
    }

    // Перевизначений метод №2 (3 параметри)
    public void ObchyslytyShylnist(string relyef, double ploshcha, int naselennia)
    {
        if (ploshcha > 0)
        {
            double shylnist = naselennia / ploshcha;
            Console.WriteLine($"Рельєф: {relyef}, Щільність населення: {shylnist} осіб на км²");
        }
        else
        {
            Console.WriteLine("Площа має бути більшою за 0.");
        }
    }
}

class Program
{
    static void Main()
    {
        Miscevist miscevist = new Miscevist();

        // Виклик першого методу
        miscevist.ObchyslytyShylnist(1200, 600000);

        // Виклик другого методу
        miscevist.ObchyslytyShylnist("Гори", 1200, 600000);
    }
}
