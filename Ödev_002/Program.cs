// 1 ile 300 sayıları arasındaki tam sayılardan tek olanların toplamı ile çift olanların toplamının farkını bulan ve bu farkın negatif mi, pozitif mi yoksa 0 mı olduğunu ekrana yazan algoritma ve akış diyagramı.
namespace _Ödev_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekveÇiftToplamArasıFark();
        }

        static void TekveÇiftToplamArasıFark()
        {
            do
            {


                try
                {
                    Console.WriteLine("Lütfen Başlangıç Noktasını Giriniz");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Lütfen Bitiş Noktasını Giriniz");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());



                    int tekSayi = 0, ciftSayi = 0;
                    for (int i = sayi1; i < sayi2; i++)
                    {

                        if (i % 2 == 0)
                        {
                            ciftSayi += i;
                        }
                        else
                        {
                            tekSayi += i;
                        }

                    }
                    Console.WriteLine($"Tek Sayiların Toplami : {tekSayi}");
                    Console.WriteLine($"Çift Sayıların Toplami : {ciftSayi}");
                    if (tekSayi - ciftSayi > 0)
                    {
                        Console.WriteLine($"Sonuc : {tekSayi - ciftSayi} - Sonuc Negatiftir. ");
                    }
                    else
                    {
                        Console.WriteLine($"Sonuc : {tekSayi - ciftSayi} - Sonuc Pozitiftir. ");
                    }
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                   
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }
    }
}

