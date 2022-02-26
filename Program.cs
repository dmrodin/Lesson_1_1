using System;

namespace Lesson_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчет расхода бензина в зависимости от расстояния и среднего расхода");
            Console.Write("Введите расстояние в км.: ");

            float fuelConsuption;
            int distance;

            try
            {
                distance = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите средний расход топлива: ");

                fuelConsuption = float.Parse(Console.ReadLine()); // Не нашел в классе Convert метода приведения к типу float, видел только для double.
                                                                        // Есть ли вообще разница в преобразовании через метод Parse в классах типов данных и в классе Convert?
                                                                        // Ну кроме того что Parse принимает на вход строку, а в Convert можно к примеру из float в int перевести.
            }
            catch (Exception)
            {
                Console.WriteLine("Введено не корректное значение!");
                Console.ReadKey();
                throw;
            }
            

            float result = distance / 100 * fuelConsuption;

            Console.WriteLine("Ожидаемый расход топлива: " + result + " л.");
            Console.ReadKey();
        }
    }
}
