using System;
internal class NewBaseType
{
    private static void Main(string[] args)
    {
        #region Degiskenler
        /*
                // int deger; deger=2; -> int türünde oluşturup, değeri atandı
                //string degisken veri; -> boşluk olamaz
                //string adı+soyadı; -> olmaz sadece "_" kullanılabilir
                //string 1deneme; -> olmaz - rakam ile başlayamaz
                // string namespace; -> olmaz, özel isimler kullanılamaz

                byte b = 5;         // -> 1 byte
                sbyte sb = 5;        // -> 1 byte

                short s = 5;        // -> 2 byte
                ushort us = 5;      // -> 2 byte - short aralığında ama pozitif değerler
                Int16 i16 = 15;     // -> 2 byte 
                int i = 2;          //-> 4 byte
                Int32 i32 = 4;      //-> 4 byte
                Int64 i64 = 8;      //-> 8 byte
                uint ui = 5;        //-> 4 byte
                long l = 4;         //-> 8 byte
                ulong ul = 4;       //-> 8 byte
                float f = 5;        //-> 4 byte
                double d = 5;       //-> 8 byte
                decimal de = 5;     //->16 byte

                char c = 'c';       //-> 3 byte
                string st = "";     //-> sınırsız

                bool bo = false;    //-> true,false olabilir.
                DateTime dt = DateTime.Now; //-> çalışma zamanının anlık tarih saat bilgisini getirir.

                object o = 5.43; //-> her tür veriyi tutabilir.

                //string ifadeler
                string str = "";
                string str1 = null;
                string str2 = string.Empty;
                string ad = "Hüseyin";
                string soyad = "ÜTEBAY";
                string tamIsim = ad + " " + soyad;

                //integer tanımlama şekilleri
                int i1 = 5;
                int i2 = 3;
                int i3 = i1 * i2;

                //boolean kullanım örnekleri
                bool b1 = 10 < 2; //-> false döner b1=false; ile aynı

                //Değişken dönüşümleri
                string str20 = "20";
                int i20 = 20;
                string yeniDeger = str20 + i20.ToString(); // i20 string'e dönüştürüldü.

                string str15 = "15";
                int i30 = 30;
                int yeniSayi = Convert.ToInt32(str15) + i30;

                //datetime
                string date = DateTime.Now.ToString("dd.MM.yyyy");
                Console.WriteLine(date);

                string date1 = DateTime.Now.ToString("dd/MM/yyyy");
                Console.WriteLine(date1);

                string hour = DateTime.Now.ToString("HH:mm");
                Console.WriteLine(hour);

                //Github içine yüklendi
                */
        #endregion
        #region Operatorler

        /*
  int x = 3;
      int y = 3;
      y = y + 2;
      Console.WriteLine(y);
      y += 2;
      Console.WriteLine(y);
      y /= 3;
      Console.WriteLine(y);
      x *= 2;
      Console.WriteLine(x);

      //Mantıksal Operatörler &&,||,!
      bool isSuccess = true;
      bool isCompleted = false;

      if (isSuccess && isCompleted) //ve
      {
          Console.WriteLine("Perfect");
      }
      if (isSuccess || isCompleted) //veya
      {
          Console.WriteLine("Great");
      }
      if (isSuccess && !isCompleted) //isCompleted true döner
      {
          Console.WriteLine("Fine");
      }

      //İlişkisel operatörler <,>,<=,=>,==,!=
      int a = 3;
      int b = 4;
      bool sonuc = a < b;
      Console.WriteLine(sonuc);
      sonuc = a > b;
      Console.WriteLine(sonuc);
      sonuc = a >= b;
      Console.WriteLine(sonuc);
      sonuc = a <= b;
      Console.WriteLine(sonuc);
      sonuc = a == b;
      Console.WriteLine(sonuc);
      sonuc = a != b;
      Console.WriteLine(sonuc);

      //Matematiksel ifadeler
      int sayi1 = 10;
      int sayi2 = 5;
      int sonuc1 = sayi1 / sayi2;
      Console.WriteLine(sonuc);
      sonuc1 = sayi1 * sayi2;
      Console.WriteLine(sonuc);
      sonuc1 = sayi1 + sayi2;
      Console.WriteLine(sonuc);
      sonuc1 = sayi1++;

      // % Mod Alır
      int sonuc2 = 20 % 3;
      Console.WriteLine(sonuc2);
     */
        #endregion
        #region TipDonusumleri
        /*
        //implicit conversation(bilinçsiz dönüşüm)
        byte a = 5;
        sbyte b = 30;
        short c = 10;
        int d = a + b + c;
        Console.Write("d:" + d);

        long h = d;
        Console.WriteLine("h:" + h);

        float i = h;
        Console.WriteLine("i:" + i);

        string e = "Hüseyin";
        char f = 'k';
        object g = e + f + d;
        Console.WriteLine("g:" + g);

        //explicit conversation (Bilinçli Dönüşüm)
        int x = 4;
        byte y = (byte)x;
        Console.WriteLine("y:" + y);

        int z = 100;
        byte t = (byte)z;
        Console.WriteLine("t:" + t);

        float w = 10.3f;
        byte v = (byte)w;
        Console.WriteLine("v:" + v);

        // ToString Methodu
        int xx = 6;
        string yy = xx.ToString();
        Console.WriteLine("yy:" + yy);

        string zz = 12.5f.ToString();
        Console.WriteLine("zz:" + zz);

        //System.Convert Sınıfı
        string s1 = "10", s2 = "20";
        int sayi1, sayi2;
        int Toplam;
        sayi1 = Convert.ToInt32(s1);
        sayi2 = Convert.ToInt32(s2);
        Toplam = sayi1 + sayi2;
        Console.WriteLine("Toplam:" + Toplam);

        // Parse
        ParseMethod();
*/
        #endregion
        #region HataYonetimi
        /*
                try
                {
                    Console.WriteLine("Bir sayı giriniz");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Girilen sayı:" + sayi);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata:" + ex.Message.ToString());
                }
                finally
                {
                    Console.WriteLine("İşlem tamamlandı");
                }

                try
                {
                    //int a = int.Parse(null);
                    //int a = int.Parse("Test");
                    int a = int.Parse("-2000000000000000000000");
                }
                catch (ArgumentNullException ex)
                {

                    Console.WriteLine("Boş değer girdiniz");
                    Console.WriteLine(ex);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Format tipi uygun değil");
                    Console.WriteLine(ex);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Değer aralık dışında");
                    Console.WriteLine(ex);
                }
        */
        #endregion
        #region if-else

        /*
                        int time = DateTime.Now.Hour;

                        if (time >= 6 && time > 11)
                            Console.WriteLine("Günaydın");

                        else if (time <= 18)
                            Console.WriteLine("iyi günler");
                        else
                            Console.WriteLine("iyi geceler");

                        string sonuc = time <= 18 ? "İyi günler":"İyi geceler";
                        sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler" : "İyi geceler";
                        Console.WriteLine(sonuc);
                        */
        #endregion
        #region Switch-case
        /*
                int month = DateTime.Now.Month;

                switch (month)
                {
                    case 1:
                        Console.WriteLine("Ocak Ayındasınız");
                        break;
                    case 2:
                        Console.WriteLine("Şubat Ayındasınız");
                        break;
                    case 3:
                        Console.WriteLine("Mart Ayındasınız");
                        break;


                    default:
                        break;
                }
                switch (month)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Kış ayındasınız");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("ilkbahar ayındasınız");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Yaz ayındasınız");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Sonbahar ayındasınız");
                        break;
                    default:
                        break;
                }
        */
        #endregion
        #region Donguler-For
        /*
                //ekrandan girilen sayıya kadar olan tek sayıları yazdır.
                Console.WriteLine("Lütfen bir sayı giriniz:");
                int sayac = int.Parse(Console.ReadLine());
                for (int i = 0; i <= sayac; i++)
                {
                    if (i % 2 == 1)
                        Console.WriteLine(i);

                }

                // 1 ile 1000 arasında ki tek ve çift sayıların toplamını ekrana yazdır
                int tekToplam = 0;
                int ciftToplam = 0;

                for (int i = 0; i <= 1000; i++)
                {
                    if (i % 2 == 1)
                        tekToplam += i;
                    else
                        ciftToplam += i;
                }
                Console.WriteLine("Tek Toplam :" + tekToplam);
                Console.WriteLine("Çift Toplam :" + ciftToplam);

                //Break, continue : Break-> ilgili koşulda döngüyü sonlandırır(döngüden çıkar). Continue ->ilgili koşulda döngü atlanır(ilgili değer döngüde atlanır ve yeni değer devam eder).
                for (int i = 1; i < 10; i++)
                {
                    if (i == 4)
                        break;
                    Console.WriteLine(i);
                }

                for (int i = 1; i < 10; i++)
                {
                    if (i == 4)
                        continue;
                    Console.WriteLine(i);
                }   

                //for(;;) -> sonsuz döngüye girer
        */
        #endregion
        #region Donguler-While
        /*
                //1'den balayarak consele'dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console 'a yazdıran program
                Console.WriteLine("Lütfen bir sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                int sayac = 1;
                int toplam = 0;
                while (sayac <= sayi)
                {
                    toplam += sayac;
                    sayac++;
                }
                Console.WriteLine(toplam / sayi);

                //a'dan z'ye kadar olan tüm harfleri ekrana yaz
                char ch = 'a';
                while (ch <= 'z')
                {
                    Console.WriteLine(ch);
                    ch++;
                }

                //foreach diziler içinde ki döngüleri yönetiriz
                string[] arabalar = { "BMW", "Ford", "Audi", "Mercedes" };
                foreach (var araba in arabalar)
                {
                    Console.WriteLine(araba);
                }
        */
        #endregion
        #region Diziler-Giris
        /*      
               //Aynı tipteki değişkenleri beraber saklamak için kullandığımız yapılardır
               //diziler 0'dan başlar yani ilk index 0 olur. 

               //-> Dizi Tanımlama
               string[] renkler = new string[5];
               string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
               int[] dizi;
               dizi = new int[5];

               //-> Dizilere Değer Atama ve Erişim
               renkler[0] = "Mavi";
               dizi[3] = 10;

               Console.WriteLine(hayvanlar[0]);
               Console.WriteLine(dizi[3]);
               Console.WriteLine(renkler[0]);

               //-> Döngülerle dizi kullanımı
               //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
               Console.WriteLine("Lütfen dizinin eleman sayısını giriniz :");
               int diziUzunlugu = int.Parse(Console.ReadLine());
               int[] sayiDizisi = new int[diziUzunlugu];

               for (int i = 0; i < diziUzunlugu; i++)
               {
                   Console.Write("Lütfen {0}. sayıyı giriniz : ", i + 1);
                   sayiDizisi[i] = int.Parse(Console.ReadLine());
               }
               int toplam = 0;
               foreach (var sayi in sayiDizisi)
               {
                   toplam += sayi;
               }
               Console.WriteLine("Ortalama :" + (toplam / diziUzunlugu));
               */
        #endregion
        #region Diziler-Array Sınıfı Metotları
        /*
                //Diziler Array Sınıfından Türerler. Bu yüzden bu sınıfın metotlarını kullanabilir.

                //-> sort
                int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
                Console.WriteLine("*** Sırasız Dizi ***");
                foreach (var sayi in sayiDizisi)
                    Console.WriteLine(sayi);
                Console.WriteLine("*** Sıralı Dizi ***");
                Array.Sort(sayiDizisi);
                foreach (var sayi in sayiDizisi)
                    Console.WriteLine(sayi);

                //-> Clear ilgili dizide verilen indexten istenilen uzunluğu siler
                Console.WriteLine("*** Clear ***");
                Array.Clear(sayiDizisi, 2, 2);

                foreach (var sayi in sayiDizisi)
                    Console.WriteLine(sayiDizisi);

                //-> Reverse ilgili diziyi tersten yazar
                Console.WriteLine("*** Reverse ***");
                Array.Reverse(sayiDizisi);

                foreach (var sayi in sayiDizisi)
                    Console.WriteLine(sayi);

                //-> IndexOf Dizide verilen elaman varsa index numarasını döner
                Console.WriteLine("*** IndexOf ***");
                Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

                // -> Resize İlgili diziyi yeniden boyutlandırır
                Console.WriteLine("*** Resize ***");
                Array.Resize<int>(ref sayiDizisi, 9);
                sayiDizisi[8] = 99;

                foreach (var sayi in sayiDizisi)
                    Console.WriteLine(sayi);
        */
        #endregion
        #region Metot Tanımlama
        /*
        //Metotlar fonksiyonlardır
        //Metotlar Class içinde tanımlanmalıdır.
        //Başka bir Class'dan metot'a ulaşılacaksa o metot'un intance'ı ile ulaşılabilir.

        //-> Tanımlama Syntax'ı
        // erisimbelirteci geridönüştipi metotadi (parametrelistesi/arguman)
        //{
        //   Komutlar;
        //   return; Geri dönüş değeri bildirir.
        //}

        int a = 2;
        int b = 3;
        Console.WriteLine(a + b);

        int sonuc = Topla(a, b);
        Console.WriteLine(sonuc);

        Metotlar m = new Metotlar(); //İlgili sınıfın intance oluşturup metot çağrıldı.
        m.EkranaYazdir(sonuc.ToString());

        int sonuc2 = m.ArttırveTopla(ref a, ref b); //Ref ile yapıldığı için a=deger1++ ile b=deger2++ olarak güncellendi.
        m.EkranaYazdir(sonuc2.ToString());
        
*/
        #endregion
        #region Metot Overloading
        /*
                //Out Parametreler
                string sayi = "999";

                bool sonuc = int.TryParse(sayi, out int outSayi);
                if (sonuc)
                {
                    Console.WriteLine("Başarılı");
                    Console.WriteLine(outSayi);
                }
                else
                {
                    Console.WriteLine("Başarısız");
                }

                Metotlar m = new Metotlar();
                m.Toplam(2, 3, out int toplamSonuc);
                Console.WriteLine(toplamSonuc);

                //Metot Overloading (Aşırı Yükleme)
                int ifade = 999;
                m.EkranaYazdir(ifade.ToString());
                m.EkranaYazdir(ifade);
                m.EkranaYazdir("Hüseyin", "ÜTEBAY");
                */
        #endregion
        #region Metot-Recursive and Extension
        /*
        //-> Rekürfis Fonksiyonlar: Öz Yineleme (kendini tekrar çağran metotlar)
        //3^4 hesaplayan metot
        int result = 1;
        for (int i = 0; i < 5; i++)
        {
            result = result * 3;
        }
        Console.WriteLine(result);

        Islemler islemler = new();
        Console.WriteLine(islemler.Expo(3, 4));

        //-> Extension Metot: statik bir metot ve parametresi this ile işaretlenmeli
        string ifade = "Hüseyin ÜTEBAY";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);

        if (sonuc)
            Console.WriteLine(ifade.RemoveWhiteSpaces());

        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.IsEven());

        Console.WriteLine(ifade.GetFirstCharacter());
*/
        #endregion

    }
    public static int Topla( int deger1,  int deger2)
    {
        return deger1 + deger2;
    }
    public static void ParseMethod()
    {
        string metin1 = "10";
        string metin2 = "10.25";
        int rakam1;
        double double1;

        rakam1 = Int32.Parse(metin1);
        Console.WriteLine("rakam1:" + rakam1);

        double1 = double.Parse(metin2);
        Console.WriteLine("double1" + double1);
    }
}

class Metotlar

{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + " " + veri2);
    }
    public int ArttırveTopla(ref int deger1, ref int deger2)
    {
        deger1 += 1;
        deger2 += 1;
        return deger1 + deger2;
    }

    public void Toplam(int a, int b, out int toplam)
    {
        toplam = a + b;
    }
}
public class Islemler
{
    public int Expo(int sayi, int üs)
    {
        if (üs < 2)
            return sayi;
        return Expo(sayi, üs - 1) * sayi;
    }
}
public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param)
    {
        foreach (var sayi in param)
        {
            Console.WriteLine(sayi);
        }
    }
    public static bool IsEven(this int param)
    {
        return param % 2 == 0;
    }
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0,1);
    }
}

