internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhập năm cần tính");
        int yearcount = Convert.ToInt32(Console.ReadLine());
        if (yearcount%4 != 0)
        {
            Console.WriteLine("Năm " + yearcount + " không phải là năm nhuận");
        }
        else
        {
            if (yearcount%100 == 0 && yearcount%400 != 0)
            {
                Console.WriteLine("Năm " + yearcount + " không phải là năm nhuận");
            }
            else
            {
                Console.WriteLine("Năm " + yearcount + " là năm nhuận");
            }
        }
    }
}