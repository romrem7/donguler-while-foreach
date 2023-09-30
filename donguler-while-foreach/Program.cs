internal class Program
{
    private static void Main(string[] args)
    {
        //While
        // 1'den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
        // Console.Write("Bir sayı giriniz : ");
        // int sayac = 1;
        // int toplam = 0;
        // int sayi = int.Parse(Console.ReadLine());
        // while (sayac <= sayi)
        // {
        //     toplam += sayac;
        //     sayac ++;
        // }
        // Console.WriteLine("Ortalama: " + toplam/sayi);

        // // a'dan z'ye kadar tüm harfleri console a yazdır.
        // char character = 'a';
        // while (character < 'z')
        // {
        //     Console.Write(character);
        //     character ++;
        // }

        Console.WriteLine("****** Foreach ******");
        string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}