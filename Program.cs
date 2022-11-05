internal class Program
{
    private static void Main(string[] args)
    {
        int teksayi = 0;
        int çiftsayi = 0;
        Console.Write("Bir sayı giriniz: ");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 1; i <= sayac; i++)
        {
            if (i % 2 == 1)
                teksayi += i;

            else
                çiftsayi += i;

        }
        Console.WriteLine("Tek sayiların toplamı: " + teksayi);
        Console.WriteLine("Çift sayiların toplamı: " + çiftsayi);

        for (int i = 0; i < 2; i++)
        {
            for (int j = i; j < 4; j++)
            Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
        }
        for(int i = 1; i < 4; i++)
        {
            if(i == 2)
              continue;
              
            Console.WriteLine("Hi!"); 
        }

        for(int i = 1; i < 4; i++)
        {
            if(i == 2)
              break;
              
            Console.WriteLine("Hello!"); 
        }



    }
}