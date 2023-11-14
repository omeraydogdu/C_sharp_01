using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaTemelleri
{
    class Donguler
    {
        public static void ForDongusu()
        {
            // for
            // int toplam=0;

            // for (int i = 0; i < 100; i++)
            // {
            //     if (i%2==0)
            //     {
            //         toplam += i;
            //     }
            // }            
            // Console.WriteLine(toplam); 

            string[] isimler = { "ada", "yiğit", "sena", "çınar", "emel" };

            // Console.WriteLine(isimler[0]);
            // Console.WriteLine(isimler[1]);
            // Console.WriteLine(isimler[2]);
            // Console.WriteLine(isimler[3]);

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.WriteLine("for bitti");

            // Uygulama-1

            // 1- Kullanıcıdan başlangıç, bitiş ve artış miktarı alınarak aralıktaki
            // tüm sayıları ekrana yazdırınız.     
            // Console.Write("başlangıç: ");
            // int baslangic = int.Parse(Console.ReadLine());

            // Console.Write("bitiş: ");
            // int bitis = int.Parse(Console.ReadLine());

            // Console.Write("artış miktarı: ");
            // int artis = int.Parse(Console.ReadLine());

            // int sayac = 0;
            // int toplam=0;
            // for (int i = baslangic; i <= bitis; i=i+artis)
            // {
            //     sayac++;
            //     toplam+=i;
            //     Console.WriteLine($"{sayac}.sayı: {i}");
            // }
            // Console.WriteLine("toplam: "+toplam);

            int[] sayilar = { 1, 3, 5, 6, 7, 23, 67, 90, 120 };
            // 2- sayilar dizisindeki hangi sayılar 3' ün katıdır?

            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     if (sayilar[i]%3==0)
            //         Console.WriteLine(sayilar[i]);
            // }

            // 3- sayilar dizisindeki sayıları toplamı kaçtır?

            // int toplam=0;
            // long carpim=1;
            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     toplam += sayilar[i];
            //     carpim *= sayilar[i];
            // }
            // Console.WriteLine("toplam: "+ toplam);
            // Console.WriteLine("çarpim: "+ carpim);


            // 4- sayilar dizindeki tek sayıların karesini ekrana yazdırınız. 

            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     if (sayilar[i]%2==1)
            //         Console.WriteLine(sayilar[i]*sayilar[i]);
            // }


            string[] arabalar = { "Opel", "Mazda", "Toyota", "Bmw", "Merdedes" };
            // 5- arabalar dizisindeki en az 5 karakterli araç isimlerini yazdırın.    

            for (int i = 0; i < arabalar.Length; i++)
            {
                if (arabalar[i].Length >= 5)
                    Console.WriteLine(arabalar[i]);
            }

        }
        public static void WhileDongusu()
        {
            // while

            // for (int i = 1; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // int i=0;
            // while (i < 10)
            // {
            //     if (i%2==0)
            //         Console.WriteLine("sayı çift: "+i);
            //     else
            //         Console.WriteLine("sayı tek: "+i);
            //     i++;
            // }

            // string name = " ";

            // while (string.IsNullOrEmpty(name))
            // {
            //     Console.Write("isminiz: ");
            //     name = Console.ReadLine();
            // }

            // Console.Write($"merhaba {name}");


            // do-while

            string name = "";
            do
            {
                Console.Write("isminiz: ");
                name = Console.ReadLine();

            } while (string.IsNullOrEmpty(name));

            Console.Write($"merhaba {name}");
            // Sınırsız sayıda ürün ismini bir dizi içinde saklayın.
            // Ürün adetini kullanıcı belirlesin.
            // Eklenen ürünler listelensin.

            // while, array
            // string[] => 5
            // class => name,price,desciption

            Console.Write("adet: ");
            int adet = int.Parse(Console.ReadLine());

            string[] urunler = new string[adet];

            int i = 0;

            do
            {
                Console.Write($"{i + 1}. ürün adı: ");
                urunler[i] = Console.ReadLine();
                i++;
            } while (adet != i);

            Console.WriteLine("ürünler listeniyor...");

            for (int a = 0; a < urunler.Length; a++)
            {
                Console.WriteLine($"{a + 1}.ürün adı: {urunler[a]}");
            }
        }
        public static void DongulerBreakContinue()
        {
            // Döngüler: break - continue

            // string name = "Abdullah Akyol";

            // for (int i = 0; i < name.Length; i++)
            // {
            //     if (name[i] == 'd')
            //         continue;
            //     Console.WriteLine(name[i]);
            // }

            // Console.WriteLine("döngü dışı");

            // int x = 0;
            // while (x<5)
            // {
            //     x++;
            //     if (x==2)
            //         continue;
            //     Console.WriteLine(x);               
            // }

            // Console.WriteLine("döngü dışı");


            // 1-100 arasındaki tek sayıların toplamı

            int x = 1;
            int toplam = 0;
            while (x < 100)
            {
                x++;
                if (x % 2 == 0)
                    continue;
                toplam += x;
            }
            Console.WriteLine("toplam: " + toplam);
        }
        public static void Uygulamalar()
        {
            // Uygulama: Asal Sayı
            // Girilen bir sayının asal olup olmadığını kontrol ediniz.
            // Bir sayı, sadece 1'e ve kendisine tam bölünebiliyorsa asal sayıdır.

            bool asalmi = true;

            Console.Write("sayı: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi == 1)
                asalmi = false;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalmi = false;
                    break;
                }
            }

            if (asalmi)
                Console.WriteLine("sayı asaldır.");
            else
                Console.WriteLine("sayı asal değildir");

            // Sayı Tahmin
            // 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın.
            // Puanlama yapınız.
            // devam etmek istiyorsa devam etsin...

            do
            {
                int tutulan = (new Random()).Next(1, 100);
                int hak = 5;
                int tur = 0;
                int sayi1;

                double sorupuani = 100 / hak;

                while (hak > 0)
                {
                    tur++;
                    Console.Write($"{tur}.sayı: ");
                    sayi1 = int.Parse(Console.ReadLine());
                    hak--;

                    if (sayi1 == tutulan)
                    {
                        double puan = 100 - (sorupuani * (tur - 1));
                        Console.WriteLine($"Tebrikler {tur} defada bildiniz.");
                        Console.WriteLine($"Toplam puan: {puan}");
                        break;
                    }
                    else
                    {
                        if (hak == 0)
                            break;

                        if (tutulan > sayi1)
                            Console.WriteLine("yukarı");
                        else
                            Console.WriteLine("aşağı");
                    }
                }
                Console.WriteLine("oyun bitti");

                Console.Write("devam etmek istiyormusunuz? (e/h): ");
                string result = Console.ReadLine();

                if (result == "h" || result == "hayır")
                    break;

            } while (true);

            // Uygulama: Bankamatik

            string secim = "";
            double bakiye = 0;
            double ekhesap = 1000;
            double ekhesapLimiti = 1000;
            do
            {
                Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçiminiz: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("bakiyeniz {0} TL", bakiye);
                        Console.WriteLine("ek hesap bakiyeniz {0} TL", ekhesap);
                        break;
                    case "2":
                        Console.Write("yatırmak istediğiniz miktar: ");
                        double yatirilan = double.Parse(Console.ReadLine());

                        if (ekhesap < ekhesapLimiti)
                        {
                            double ekhesaptankullanilan = ekhesapLimiti - ekhesap;
                            if (yatirilan >= ekhesaptankullanilan)
                            {
                                ekhesap = ekhesapLimiti;
                                bakiye = yatirilan - ekhesaptankullanilan;
                            }
                            else
                            {
                                ekhesap += yatirilan;
                            }
                        }
                        else
                        {
                            bakiye += yatirilan;
                        }
                        break;
                    case "3":
                        Console.Write("çekmek istediğiniz miktar: ");
                        double cekilecekmiktar = double.Parse(Console.ReadLine());
                        if (cekilecekmiktar > bakiye)
                        {
                            double toplam = bakiye + ekhesap;
                            if (toplam >= cekilecekmiktar)
                            {
                                Console.Write("ek hesap kullanılsın mı? (e/h)");
                                string ekhesaptercihi = Console.ReadLine();

                                if (ekhesaptercihi == "e")
                                {
                                    Console.Write("paranızı alabilirsiniz.");
                                    ekhesap -= (cekilecekmiktar - bakiye);
                                    bakiye = 0;
                                }
                                else
                                {
                                    Console.WriteLine("bakiyeniz yetersiz");
                                }
                            }
                        }
                        else
                        {
                            Console.Write("paranızı alabilirsiniz.");
                            bakiye -= cekilecekmiktar;
                        }
                        break;
                    case "4":
                        Console.WriteLine("çıkış");
                        break;
                    default:
                        Console.WriteLine("hatalı seçim");
                        break;
                }
            } while (secim != "4");

            Console.WriteLine("uygulamadan çıkıldı.");
        }
    }
}
