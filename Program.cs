using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayi1, sayi2, toplam = 0, sayac = 0;
            double ortalama = 0.0, alan, s1, s2;
            int soruno;
            Console.Write("Soru Numarasını giriniz ---> ");
            soruno = Convert.ToSByte(Console.ReadLine());
            switch (soruno)
            {
                case 1:
                    // Girilen iki sayının ortalamasını hesaplayan programı yazınız.
                    Console.Write("1. Sayı Giriniz ---> "); 
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayı Giriniz ---> ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    toplam = sayi1 + sayi2;
                    ortalama = toplam / 2;
                    Console.WriteLine("Ortalama : " + ortalama);
                    break;
                case 2:
                     // Girilen bir sayının pozitif mi negatif mi olduğunu ekrana yazdıran programı yazınız.
                    Console.Write("Sayı Giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi > 0)
                        Console.WriteLine("Girdiğiniz " + sayi + " Sayısı Pozitiftir!");
                    else if (sayi < 0)
                        Console.WriteLine("Girdiğiniz " + sayi + " Sayısı  Negatiftir!");
                    else
                        Console.WriteLine("Girdiğiniz " + sayi + " Sayısı Nötrdür!");
                    break;
                case 3:
                    // Bir kenar uzunluğu ve o kenara ait yüksekliği dirilen üçgenin alanı hesaplayan programı yazınız.
                    double uzunluk, yukseklik;
                    Console.Write("Uzunluk Değeri Giriniz ---> ");
                    uzunluk = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Yükseklik Değeri Giriniz ---> ");
                    yukseklik = Convert.ToDouble(Console.ReadLine());
                    alan = (yukseklik * uzunluk) / 2;
                    Console.WriteLine("Üçgenin alanı : " + alan);
                    break;
                case 4:
                    // Girilen iki sayıdan hangisinin daha küçük olduğunu ekrana yazdıran programı yazınız.
                    Console.Write("1. Sayıyı Giriniz ---> ");
                    s1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Sayıyı Giriniz ---> ");
                    s2 = Convert.ToDouble(Console.ReadLine());
                    if (s1 < s2)
                        Console.WriteLine("Girdiğiniz " + s1 + " sayısı " + s2 + " Sayısına göre daha küçüktür");
                    else if (s2 < s1)
                        Console.WriteLine("Girdiğiniz " + s2 + " sayısı " + s1 + " Sayısına göre daha küçüktür");
                    else
                        Console.WriteLine("Girdiğiniz Sayılar Eşittir!");
                    break;
                case 5:
                    // Bir öğrencinin almış olduğu vize notu ile final notunun ortalamasını hesaplayan programı yazınız.
                    double vize, final;
                    Console.Write("Vize Notunuzu Giriniz ---> ");
                    vize = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Final Notunuzu Giriniz ---> ");
                    final = Convert.ToInt32(Console.ReadLine());
                    ortalama = Convert.ToInt32(vize * 0.4 + final * 0.6);
                    Console.WriteLine("Ortalamanız = " + ortalama);
                    break;
                case 6:
                    // Yarıçapı girilen dairenin çevresini ve alanını hesaplayan programı yazınız.
                    double yaricap, cevre;
                    Console.Write("Daire'nin yarıçapını giriniz ---> ");
                    yaricap = Convert.ToDouble(Console.ReadLine());
                    alan = 3.14 * yaricap * yaricap;
                    cevre = 2 * 3.14 * yaricap;
                    Console.WriteLine("Alan : " + alan);
                    Console.WriteLine("Çevre : " + cevre);
                    break;
                case 7:
                    // Klavyeden girilen 10 adet sayıdan 50'den büyük olanları ekrana yazdıran programı yazınız.
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        if (sayi > 50)
                        {
                            sayac = sayac + 1;
                            Console.Write("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.Write("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("50'den Büyük Sayılar : " + sayac);
                    break;
                case 8:
                    // Klavyeden girilen 10 adet sayıdan 100'den büyük kaç adet olduğunu ekranda yazdıran programı yazınız.
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        if (sayi > 100)
                        {
                            sayac = sayac + 1;
                            Console.Write("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Console.Write("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("100'den Büyük " + sayac + " sayı bulunmaktadır.");
                    break;
                case 9:
                    // Klavyeden sıfır girilinceye kadar sayı okumaya devam edilecektir. Sıfır girildiğinde girilen sayıların toplamını ve ortalamasını ekranda gösteren programı yazınız.
                    while (true)
                    {
                        Console.Write("Sayı giriniz ---> ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        if (sayi == 0)
                        {
                            break;
                        }
                        toplam = toplam + sayi;
                        sayac++;
                        ortalama = toplam / sayac;
                    }
                    Console.WriteLine("Girdiğiniz Sayıların Toplamı: " + toplam);
                    Console.WriteLine("Girdiğiniz Sayıların Ortalaması: " + ortalama);
                    break;
                case 10:
                    // Klavyeden girilen 3 adet sınav notunun ortalamasını hesaplayıp ekranda gösteren programı yazınız. ( Not: Sınav notlarının 0-100 aralığında olması kontrol edilmelidir.)
                    double not1, not2, not3;
                    Console.Write("1. Notunuzu giriniz ---> ");
                    not1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2. Notunuzu giriniz ---> ");
                    not2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("3. Notunuzu giriniz ---> ");
                    not3 = Convert.ToDouble(Console.ReadLine());
                    if (not1 >= 0 && not1 <= 100 && not2 >= 0 && not2 <= 100 && not3 >= 0 && not3 <= 100)
                    {
                        ortalama = (not1 + not2 + not3) / 3;
                        Console.WriteLine("Notlarınızın ortalaması: " + ortalama);
                    }
                    else
                        Console.WriteLine("Girdiğiniz not değerleri '0' ve '100' arasında olmaladır.");
                    break;
                case 11:
                    // 1 ile 1000 arasındaki sayıları ekrana yazdıran programı yazınız.
                    for (int i = 1; i <= 1000; i++)
                        Console.WriteLine(i);
                    break;
                case 12:
                    // Girilen sayının 0'dan 100'e kadar olan sayılardan olup olmadığını kontrol eden programı yazınız. ( 0 ve 100 dahil)
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi >= 0 && sayi <= 100)
                        Console.WriteLine("Girdiğiniz sayı '0' ve '100' arasındadır.");
                    else
                        Console.WriteLine("Girdiğiniz sayı '0' ve '100' arasında değildir.");
                    break;
                case 13:
                    // 1'den N'e kadar olan tamsayıların toplamını hesaplayan programı yazınız.
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= sayi; i++)
                        toplam = toplam + i;
                    Console.WriteLine("1'den " + sayi + "'e kadar olan sayıların toplamı : " + toplam);
                    break;
                case 14:
                    // Klavyeden girilen 3 adet sınav notunun ortalamasını hesaplayıp ekranda gösteren programı yazınız. ( Not: Sınav notlarının 0-100 aralığında olması kontrol edilmelidir.)
                    Console.WriteLine("10. Soru ile aynı olduğu için yapılmamıştır!");
                    break;
                case 15:
                    // Derece cinsinden girilen bir açıyı, Radyan ve Grad cinsine çeviren programı yazınız.
                    int derece, radyan, grad;
                    double pi = 3.14;
                    Console.Write("Açıyı giriniz ---> ");
                    derece = Convert.ToInt32(Console.ReadLine());

                    radyan = Convert.ToInt32(derece * pi / 180);
                    grad = derece * 200 / 180;

                    Console.WriteLine("Radyan = " + radyan);
                    Console.WriteLine("Grad = " + grad);
                    break;
                case 16:
                    // Girilen bir sayısın tek mi çift mi olduğunu hesaplayan ve sonucu ekrana yazdıran porgramı yazınız.
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi % 2 == 0)
                        Console.WriteLine("Girdiğiniz "+ sayi +" sayısı çift bir sayıdır.");
                    else
                        Console.WriteLine("Girdiğiniz "+ sayi +" sayısı tek bir sayıdır.");
                    break;
                case 17:
                    // Girilen bir sayının mutlak değerini hesaplayan ve sonucu ekrana yazdıran programı yazınız.
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    int mutlakDeger = Math.Abs(sayi);
                    Console.WriteLine("Girilen sayının mutlak değeri: " + mutlakDeger);
                    break;
                case 18:
                    // Girilen bir X sayısının yine girilen bir Y sayısına tam bölünüp bölünmediğini ekrana yazdıran programı yazınız.
                    Console.Write("1. Sayıyı giriniz ---> ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayıyı giriniz ---> ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    if (sayi1 % sayi2 == 0)
                        Console.WriteLine("Girdiğiniz " + sayi1 + " sayısı " + sayi2 + " sayısana tam bölünür.");
                    else
                        Console.WriteLine("Girdiğiniz " + sayi1 + " sayısı " + sayi2 + " sayısana tam bölünmez.");
                    break;
                case 19:
                    // 1'den N'e kadar olan çift tam sayıların toplamını hesaplayan programı yazınız.
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= sayi; i++)
                    {
                        if (i % 2 == 0)
                            toplam = toplam + i;
                    }
                    Console.WriteLine(sayi + " sayısına kadar çift sayıların toplamı: " + toplam);
                    break;
                case 20:
                    // Katsayı değerleri girilen birinci dereceden denklemin kökünü hesaplayan programı yazınız. ( ax + b = c ) 
                    int kök;
                    Console.Write("A değeri giriniz");
                    int AA = Convert.ToInt32(Console.ReadLine());
                    Console.Write("B değeri giriniz");
                    int BB = Convert.ToInt32(Console.ReadLine());
                    Console.Write("C değeri giriniz");
                    int CC = Convert.ToInt32(Console.ReadLine());
                    kök = (CC - BB) / AA;
                    Console.WriteLine("Kök = " + kök);
                    break;
                case 21:
                    /*
                     * A≠0 olmak üzere katsayıları girilen ikinci dereceden ( ax² + bx + c = 0 ) denkleminin köklerini hesaplayan programı yazınız.
                     * Not: İkinci dereceden denklemin köklerini hesaplamak için öncelikle diskriminant hesaplaması yapmamız gerekiyor. Daha sonra diskriminantın durumuna göre kökler hesaplanır. ( Diskriminant =  b² - 4ac )
                    */
                    Console.Write("A değeri giriniz");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("B değeri giriniz");
                    int B = Convert.ToInt32(Console.ReadLine());
                    Console.Write("C değeri giriniz");
                    int C = Convert.ToInt32(Console.ReadLine());
                    double d = (B * B) - (4 * A * C);
                    if (d > 0)
                    {
                        double x1 = ((-B - Math.Sqrt(d)) / (2 * A));
                        double x2 = ((-B + Math.Sqrt(d)) / (2 * A));
                        Console.WriteLine("Denklemin iki kökü vardır = ");
                        Console.WriteLine("x1 = " + x1);
                        Console.WriteLine("x2 = " + x2);
                    }
                    else if (d == 0)
                    {
                        double x = -B / (2 * A);
                        Console.WriteLine("Denklemin bir kökü vardır =");
                        Console.WriteLine("x = " + x);
                    }
                    else
                    {
                        Console.Write("Sanal kök vardır");
                    }
                    break;
                case 22:
                    /*
                     * Girilen kilo ve boy bilgilerine göre Beden kitle/kütle indeksini hesaplayan aynı zamanda bu sonuca göre kişilerin ideal kilo durumunu ekrana yazdıran programı yazınız.
                     * Not 1: Beden kitle/kütle indeksi = Kilo / Boy * Boy
                     * Not 2: Kilo => kg , Boy => m
                     * Not 3: Beden kitle/kütle indeksi < 18,5 ise Zayıf
                            18,5 < Beden kitle/kütle indeksi < 24,9 ise Normal
                            25 < Beden kitle/kütle indeksi < 29,9 ise Fazla Kilolu
                            30 < Beden kitle/kütle indeksi < 34,9 ise I. derece obez
                            35 < Beden kitle/kütle indeksi < 39,9 ise II. derece obez
                            Beden kitle/kütle indeksi > 40 ise III. derece obez
                     */
                    double boy, kilo, indeks;
                    Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1,65) --->  ");
                    boy = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Kilonuzu Giriniz --->  ");
                    kilo = Convert.ToDouble(Console.ReadLine());
                    indeks = kilo / (boy * boy);
                    Console.WriteLine("Vücut Kitle İndeksiniz : " + indeks);
                    if (indeks < 18.5)
                        Console.WriteLine("Zayıf");
                    else if (indeks >= 18.5 && indeks < 24.9)
                        Console.WriteLine("Normal");
                    else if (indeks >= 25 && indeks < 29.9)
                        Console.WriteLine("Fazla Kilolu");
                    else if (indeks <= 30 && indeks < 34.9)
                        Console.WriteLine("I. Derece Obez");
                    else if (indeks <= 35 && indeks < 39.9)
                        Console.WriteLine("II. Derece Obez");
                    else
                        Console.WriteLine("III. Derece Obez");
                    break;
                case 23:
                    /*
                     Bir fabrikada işçinin alacağı ücret hesaplanırken şu kraterlere uyulmaktadır; Eğer işçi 40 saatten az çalışmışsa çalıştığı saat ve saat ücreti çarpılarak
                    alacağı ücret hesaplanıyor, eğer işçi 40 saat ve daha fazla çalışmışsa çalıştığı 2 saat olarak hesaplanacak buna göre bilgileri alınarak ödenecek tutarı
                    yazdıran programı yazınız.
                    */
                    double Scalis, Sucret, Ucret;
                    Console.Write("Kaç saat çalıştığınızı yazınız --->  ");
                    Scalis = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Saat ücreti giriniz --->  ");
                    Sucret = Convert.ToDouble(Console.ReadLine());
                    if (Scalis < 40)
                        Ucret = Scalis * Sucret;
                    else
                        Ucret = ( Scalis * 2) * Sucret;
                    Console.Write("Alacağınız ücret : " + Ucret + " TL ");
                    break;
                case 24:
                    // Girilen pozitif bir tamsayının tam bölenlerini bulup ekrana yazdıran programı yazınız.
                    Console.Write("Sayı giriniz --->  ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if(sayi > 0)
                    {
                        Console.Write("Girdiğiniz sayının tam bölenleri : ");
                        for (int i = 1; i <= sayi; i++)
                        {
                            if (sayi % i == 0)
                                Console.Write(i + " - ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz değer pozitif tamsayı değildir.");
                    }
                    break;
                case 25:
                    int faktoriyel = 1;
                    // Girdiğiniz pozitif bir tamsayının faktöriyelini hesaplayan programı yazınız.
                    Console.Write("Faktröriyelinin bulunmasını istediğiniz bir sayı giriniz --->  ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if(sayi > 0)
                    {
                        for (int i = 1; i <= sayi; i++)
                            faktoriyel = faktoriyel * i;
                            Console.WriteLine(sayi + "! = " + faktoriyel);
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz değer pozitif tamsayı değildir.");
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış soru numarası girdiniz...!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
