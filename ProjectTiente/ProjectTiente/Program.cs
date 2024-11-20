class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so tien USD can chuyen doi: ");
        int Rate = 23000;

        int usdAmount;
      
        Console.ReadLine(usdAmount);

        int vndAmount = usdAmount * Rate;

        Console.WriteLine($"So tien duoc quy doi sang la: {vndAmount} VND." );
    }
}
    
