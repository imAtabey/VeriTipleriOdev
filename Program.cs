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

