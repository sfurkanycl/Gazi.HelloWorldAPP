using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Gazi.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi giriniz");
            //string isim1=Console.ReadLine();
            //Console.WriteLine("kaç kere yazılsın");
            //byte tekrar =byte.Parse(Console.ReadLine());

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i+1}.{isim1}");
            //}

            //for (int i = 0; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //try
            //{
            //    Console.WriteLine("Başlangıç değeri giriniz");
            //    int bas = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Bitiş değeri giriniz");
            //    int bit = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Tek mi çift mi sayılar gözüksün");
            //    string cevap = (Console.ReadLine());

            //    int sonuc = 0;
            //    if (bas > bit)
            //    {
            //        int temp = bas;
            //        bas = bit;
            //        bit = temp;
            //    }
            //    for (int i = bas; i < bit; i++)
            //    {
            //        //Console.WriteLine(i);
            //        //sonuc = sonuc + i;
            //        if (i % 2 == (cevap == "tek" ? 1 : 0))
            //        {
            //            Console.WriteLine(i);
            //            //sonuc = sonuc + i;
            //            sonuc += i;
            //        }

            //    }
            //    Console.WriteLine(sonuc);

            //}
            //catch (OverflowException)
            //{

            //    Console.WriteLine("Çok büyük veya çok küçük değer girdiniz");
            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("Lütfen sayı giriniz");
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("Bilinmeyen bir hata oldu");
            //}

            //Console.WriteLine("Taban Giriniz");
            //int taban = int.Parse (Console.ReadLine());
            //Console.WriteLine("Üs Giriniz");
            //int üs = int.Parse (Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 0; i <üs ; i++)
            //{
            //    sonuc *= taban;
            //}
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Sayı Giriniz");
            //int sayı = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 1;  i <= sayı; i++) 
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);

            //Console.WriteLine("sayı giriniz");
            //int sayı=int.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 2; i <= (sayı/2); i++)
            //{
            //    if (sayı % i ==0) 
            //    {
            //        sayac++;
            //        break;
            //    }
            //}
            //Console.WriteLine(sayac == 0 ? "Asal Değil!" : "Asal");



            //for ( ;  ; )
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz");
            //   string user = Console.ReadLine();
            //    Console.WriteLine("Şifrenizi giriniz");
            //    string password = Console.ReadLine();
            //    if (user=="admin" && password=="123")
            //    {
            //        Console.WriteLine("Giriş yaptınız");
            //        break;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Tekrar Deneyiniz");
            //    }


            //double max = double.MinValue, toplam = 0, sayac = 0;
            //for (; ; )
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    double sayi1 = double.Parse(Console.ReadLine());
            //    toplam += sayi1;
            //    sayac++;
            //    if (sayi1 > max)
            //    {
            //        max = sayi1;
            //    }
            //    Console.WriteLine("Devam etmek istiyor musunuz");
            //    string cvp = Console.ReadLine();
            //    if (cvp.ToUpper() == "H")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"Girdiğiniz en büyük sayı:{max}\nSayıların toplamı:{toplam}\nGirilen sayıların ortalaması:{toplam / sayac}");


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }
            //    Console.WriteLine();
            //}




            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //Console.WriteLine("Enter row count:");
            //int satir = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter column count");
            //int sutun = int.Parse(Console.ReadLine());

            //for (int i = 0;  i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}



            //for (int a = 1; a < 9; a++)
            //{
            //    for (int b = 0; b < 9; b++)
            //    {
            //        for (int c = 0; c < 9; c++)
            //        {
            //            for (int d= 0; d < 9; d++)
            //            {
            //                if (1000 * a + 100 * b + 10 * c + d == 4 *(1000 * d + 100 * c + 10 * b + a) )
            //                {
            //                    Console.WriteLine($"{a} {b} {c} {d}");
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}




            //for (int i = 1; i < 100; i++) 
            //{
            //    for (int j = 1; j < 100; j++)
            //    {
            //        for (int k = 1; k < 100; k++)
            //        {
            //            if (i * i + j * j == k * k)
            //            {
            //                Console.WriteLine($"{i} {j} {k}");
            //            }
            //        }
            //    }
            //}



            //int start;
            //for (; ;)
            //{
            //    Console.WriteLine("Enter Starting Number");
            //    start = int.Parse(Console.ReadLine());
            //    if (start>2)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can not enter a number lower than 2");
            //    }
            //}

            //Console.WriteLine("Enter End Number");
            //int end = int.Parse(Console.ReadLine());
            //for (int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i / 2); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(count > 0 ? $"{i}-Is Not Prime" : $"{i}-Prime"); 
            //}



            //int count = 0;  
            //while (count < 5)
            //{
            //    Console.WriteLine("Gazi");
            //    count++;
            //}


            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayı = int.Parse(Console.ReadLine());
            //    sum += sayı;
            //    Console.WriteLine("Başka sayı girmek ister misiniz? E/H");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "H")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(sum);
            //}




            //int sum = 0;
            //string answer;
            //do
            //{
            //    Console.WriteLine("Enter a number");
            //    int number = int.Parse(Console.ReadLine());
            //    sum+= number;
            //    Console.WriteLine("Would you like to continue?");
            //    answer = Console.ReadLine();
            //} while (answer == "Y");
            //Console.WriteLine(sum);



            //for (int i = 0; i < 10; i++)
            //{
            //    Random rnd = new Random();
            //    int number = rnd.Next();
            //    Console.WriteLine(number);
            //}



           Random rnd = new Random();
            int number;
            int sayac = 0;
            Console.WriteLine("Select level");
            int level = int.Parse(Console.ReadLine());
            int point = 100;
            if (level==1)
            {
                Console.WriteLine("The first level 0-10");
                number = rnd.Next(10);
                while (true)
                {
                    Console.WriteLine("Guess the number");
                    int user = int.Parse(Console.ReadLine());
                    if (user == number)
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number! Try again! Remaining Right: " + (5 - sayac));
                        Console.WriteLine(point);
                        Console.ReadKey();
                        Console.Clear();
                        point -= 5;
                    }
                    sayac++;
                    if (sayac >= 5)
                    {
                        Console.WriteLine("Game Over!");
                        break;
                    }


                }
            }
            if (level==2)
            {
                Console.WriteLine("The second level 0-30");
                number = rnd.Next(30);
                while (true)
                {
                    Console.WriteLine("Guess the number");
                    int user = int.Parse(Console.ReadLine());
                    if (user == number)
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number! Try again! Remaining Right: " + (3 - sayac));
                        Console.WriteLine(point);
                        Console.ReadKey();
                        Console.Clear();
                        point -= 20;
                    }
                    sayac++;
                    if (sayac >= 3)
                    {
                        Console.WriteLine("Game Over!");
                        break;
                    }


                }
            }
            if (level==3)
            {
                Console.WriteLine("The thırd level 0-50");
                number = rnd.Next(50);
                while (true)
                {
                    Console.WriteLine("Guess the number");
                    int user = int.Parse(Console.ReadLine());
                    if (user == number)
                    {
                        Console.WriteLine("You won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number! Try again! Remaining Right: " + (1 - sayac));
                        Console.WriteLine(point);
                        Console.ReadKey();
                        Console.Clear();
                        point -= 30;
                    }
                    sayac++;
                    if (sayac >= 1)
                    {
                        Console.WriteLine("Game Over!");
                        break;
                    }


                }
            }

           






        }
    }
}