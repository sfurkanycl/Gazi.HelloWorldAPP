
namespace Gazi.HelloWorldAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Hello World");
            //    byte a = 30;
            //    double d = 40;
            //    Console.WriteLine(a + d);

            //    byte c, b;
            //    c = 55; b = 60;

            //int number = 100;
            //Console.WriteLine(number);
            //number = 200;
            //Console.WriteLine(number);

            //byte s1 = 50;
            //short s2 = 50;
            //int s3 = 50;    
            //long s4 = 50;

            //var isim = "furkan";
            //var sayi = 100;

            //string isim = "furkan";
            //string soyad = "yücel";

            //Console.WriteLine("merhaba " + isim +" " + soyad);
            //Console.WriteLine("merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"merhaba {isim} {soyad}");

            //Console.WriteLine("İsminizi Giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyad Giriniz:");
            //var soyad = Console.ReadLine();
            //Console.WriteLine("yaşınızı giriniz:");
            //Byte yas = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine($"Hoşgeldiniz {isim} {soyad}");



            //Console.WriteLine("1.sayı girin");
            //int sayı1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayı girin");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"girilen sayıların toplamı: {sayı1 + sayi2}");





            //double maas = 5000;
            //maas += 1000; //maas=maas+1000
            ////Console.WriteLine(maas);

            //int sayi1 = 70;
            //int sayi2 = 20;

            //string sonuc = sayi2 > sayi1 ? "sayı 2 büyüktür" : "sayı 1 büyüktür yada sayılar eşittir";
            //Console.WriteLine(sonuc);





            //TÜR DÖNÜŞÜMLERİ(Type Casting)
            //byte sayi = 20;
            //int number = sayi; //Implicit Type Casting

            //checked
            //{
            //    int sayi = 20;
            //    byte number = (byte)sayi; //Explicit Type Casting 
            //    Console.WriteLine(number);
            //}

            //Büyük tür->Küçük tür RİSK:Değer kaybı

            //string sayi = "25";
            ////byte number = Convert.ToByte(sayi);
            //int number = int.Parse(sayi);    







        }
    }
}


//Namespace:İçinde classları bulunduran yapılardır
//{}:Blok yapıları (scope)
//Class:İçinde metodları bulunduran yapılarıdr
//Metod:İş yapan kod bloklarıdır
//Main metodu konsol uygulamalarının giriş noktasıdır.Bulunması zorunludur
//Syntax:Kod yazım kuralları
//Build->Derleme(Compline):proglamalama dilinin makina diline çevrilmesi işlemi
//Ctrl+s:kaydet 
//ctrl+k+d:düzenleme 
//ctrl+k+c:yoruma dönüştürür 
//ctrl+k+u:yorumu koda çevirir
//blok tanımlamalarında noktalı virgül yok geri kalanda hep var
//solution:içinde birden fazla proje bulundurabilen yapılara denir
//:ctrl+b:derleme
//MS-IL: Microsoft Intermediate Language
//C#->Build->MS-IL(exe)->Runtime->JIT Compiler->Binary(0-1)
//Runtime:çalışma zamanı
//.Net Core->Core Common Language Runtime
//JIT:Just In Time
//Compiler:Derleyici
//.NET:Mıcrosoft tarafından yazılım geliştirme için tasaralanan bir framework. içinde programlama dilleri
//editörler derleyiciler kütüphaneler bulunur 
//programlama dilleri:C#-visual Basic-F#
//Editör:visual studio-visual studio code
//kütüphaneler:içinde classlar bulunur
//derleyiciler:kodları makina diline çevirmek için gerekli yazılımlar

//desktop(masaüstü)
//web based software (web tabanlı yazılım)
//mobile application(android-ıos) xamarin ile 
//game software (unity ile)
//İOT:internet of thıngs (akıllı cihazlar için yazılımlar)
//AI:(yapay zeka uygulamaları yapılabilir)


//cross platform:windows macOS linux işletim sisteminde çalışabilen uygulamalar

//const yazıldığı an bir daha değiştirilemez
//static program çalıştığı sürece hafızada bulunur 
//const byte a;
//a = 30 bu yanlış 
//const byte a = 30 bu doğru
//değişken ismi karakter veya sayı ile başlamaz
//sadece alt tireye izin verir (_)
//değişken isminde boşluk olmaz 
//bit = 0-1
//8 bit = 1 byte 
//1024 byte = 1 kilo bayt (KB)
//1024KB = 1 megabyte (MB)
//1024MB = 1 GB
//1024GB = 1 TB

//Binary: 2'li sayı sistemi 
//Decimal: 10 tabanlı sayı sistemi
//BYTE 0-255 arasındadır 8 bit var 
//sbyte -128 yüz yirmi yedi arası sekiz bit
//float: 32 bitlik reel değeri saklamak için kullanılır 
//float f = 32.12f
//double 64 bitlik reel değerleri saklamak için kullanılır 
//double a =3.12 veya 3.12D
//decimal a = 3.12m veya 3.12M 128 bitlik değerleri saklar 
//bool: doğru veya yanlış değerleri saklamak için kullanılır
//bool sonuc = false;
//char:tek bir karakte saklamak için kullanılır 16 bitlik alan kaplar char tipinde tek tırnak (' ') içerisine yazılır
//string:metinsel verileri saklamak için kullanılır değer ataması çift tırnak (" ") içerisine yapılır
//"var" her yerde kullanılabilir (string isim = "furkan"; yerine var isim = "furkan")


//0 && 0 = 0
//0 && 1 = 0
//1 && 0 = 0
//1 && 1 = 1

//0 || 0 = 0
//0 || 1 = 1
//1 || 0 = 1
//1 || 1 = 1
//c# Tip güvenliği (Type Safety) sağlayan bir proglamlama dilidir. Bu özellik,veri tipine uygun olmayan tipte değer atanmasının önüne geçer.
//Eğer bu değeri uygun hale getirerek atamak istersek,TÜR DÖNÜŞÜMÜ (Type Casting) yapmamız gerekir.




