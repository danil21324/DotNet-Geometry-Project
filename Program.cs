using System;
using GeometryLibrary;

namespace GeometryDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- Демонстрація роботи з класом Куб ---");
            Console.WriteLine();

            Console.Write("Будь ласка, введіть довжину сторони куба: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double сторона))
            {
                try
                {
                    // Створюємо екземпляр класу Куб
                    Куб мійКуб = new Куб(сторона);

                    Console.WriteLine($"\nСтворено куб зі стороною: {мійКуб.Сторона}");

                    // Використовуємо функції класу для обчислень
                    double обєм = мійКуб.ОбчислитиОбєм();
                    double площаПоверхні = мійКуб.ОбчислитиПлощуПоверхні();

                    // Виводимо результати
                    Console.WriteLine($"Об'єм куба: {обєм:F2}");
                    Console.WriteLine($"Площа повної поверхні куба: {площаПоверхні:F2}");
                }
                catch (ArgumentException ex)
                {
                    // Обробляємо виняток, якщо сторона була некоректною
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Помилка: {ex.Message}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка: Введено некоректне число.");
                Console.ResetColor();
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
