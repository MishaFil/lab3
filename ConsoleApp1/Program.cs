namespace Lab3git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а:");
            Console.WriteLine("Введите число b:");
            double? b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. Сумма");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            Console.WriteLine("Результат: ");
            int? c = Convert.ToInt16(Console.ReadLine());
        }
    }
}