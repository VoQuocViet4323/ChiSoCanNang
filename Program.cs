using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        double height;
        double weight;
        Console.WriteLine("Nhap chieu cao");
        height = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap can nang");
        weight = float.Parse(Console.ReadLine());
        double bmi = weight / Math.Pow(height, 2);
        bmi = Math.Round(bmi,1);
        Console.WriteLine("BMI: " + bmi);
        if(bmi < 18){
            Console.WriteLine("Thieu' can");            
        }else if(bmi < 25){
            Console.WriteLine("Binh` thuong`");
        }else if(bmi < 30){
            Console.WriteLine("Thua` can");
        }else 
            Console.WriteLine($"Beo' phi`");
    }
}