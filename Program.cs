namespace telefonUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<rehber> rb = new List<rehber>();
            int secim=-1;
            rb.Add(new rehber { Isim = "elif", Soyisim = "tilki", Numara = 1 }); // 5 varsayılan kişi
            rb.Add(new rehber { Isim = "elif", Soyisim = "a", Numara = 2 });
            rb.Add(new rehber { Isim = "yılmaz", Soyisim = "c", Numara = 3 });
            rb.Add(new rehber { Isim = "ayşe", Soyisim = "e", Numara = 4 });
            rb.Add(new rehber { Isim = "ayşe", Soyisim = "c", Numara = 5 });
            while (true)
            {
                if (secim == -1)
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("ANA MENÜ");
                    Console.WriteLine("(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n" +
                        "(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n" +
                        "(5) Rehberde Arama Yapmak\n" +
                        "(0) menüden çıkış﻿");
                    Console.WriteLine("**********************************************");

                    Console.Write("seçiminiz:");
                    secim = Convert.ToInt32(Console.ReadLine());
                }            
                
                if (secim == 1)
                {
                    Console.Write("Lütfen isim giriniz             :");
                    string isim = Console.ReadLine();
                    Console.Write("Lütfen soyisim giriniz          :");
                    string soyisim = Console.ReadLine();
                    Console.Write("Lütfen telefon numarası giriniz :");
                    int numara = Convert.ToInt32(Console.ReadLine());
                 
                    rb.Add(new rehber { Isim=isim,Soyisim=soyisim,Numara=numara});
                    secim = -1;
                }


                if (secim == 2)
                {
                    Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string isimorsoyisim = Console.ReadLine();
                    int sayac = 0;
                    
                    for (int i=0;i<rb.Count;i++)
                    {

                        if (rb[i].Isim==isimorsoyisim || rb[i].Soyisim == isimorsoyisim)
                        {
                            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", rb[i].Isim);
                            string secim3 = Console.ReadLine();
                            if (secim3 == "y")
                            {
                                rb.Remove(rb[i]);
                            }                           
                            sayac = 1;
                            break;
                        }
                                                
                    }
                    if (sayac == 0)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\r\n  " +
                            "* Silmeyi sonlandırmak için : (1)\r\n  " +
                            "* Yeniden denemek için      : (2)");
                        Console.Write("seçim:");
                        int secim2 = Convert.ToInt32(Console.ReadLine());

                        if (secim2 == 1)
                        {
                            secim=-1;
                        }
                        if (secim2 == 2)
                        {
                            secim = 2;
                        }
                    }
                    else
                    {
                        secim = -1;
                    }

                }

                if (secim == 3)
                {
                    Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string isimorsoyisim = Console.ReadLine();
                    int sayac = 0;

                    for (int i = 0; i < rb.Count; i++)
                    {

                        if (rb[i].Isim == isimorsoyisim || rb[i].Soyisim == isimorsoyisim) 
                        {
                            Console.Write("yeni numara:");
                            int yeninumara = Convert.ToInt32(Console.ReadLine());
                            rb[i].Numara = yeninumara;
                            sayac = 1;
                            break;
                        }                            
                    }
                    if (sayac == 0)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\r\n  " +
                            "* Güncellemeyi sonlandırmak için : (1)\r\n  " +
                            "* Yeniden denemek için      : (2)");
                        Console.Write("seçim:");
                        int secim2 = Convert.ToInt32(Console.ReadLine());

                        if (secim2 == 1)
                        {
                            secim = -1;
                        }
                        if (secim2 == 2)
                        {
                            secim = 3;
                        }
                    }
                    else
                    {
                        secim = -1;
                    }
                }
                if (secim == 4)
                {
                    Console.WriteLine("Telefon Rehberi\n**********************************************");
                    foreach(var item in rb)
                    {
                        Console.WriteLine("isim: {0} soyisim: {1}  telefon numara: {2}", item.Isim, item.Soyisim, item.Numara);
                    }

                    secim = -1;

                }
                if (secim == 5)
                {
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n**********************************************\n"+
                        "İsim veya soyisime göre arama yapmak için: (1)\n" +
                        "Telefon numarasına göre arama yapmak için: (2)");

                    int secim2 = Convert.ToInt32(Console.ReadLine());
                    if (secim2 == 1)
                    {
                        Console.Write("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                        string isimorsoyisim = Console.ReadLine();

                        for (int i = 0; i < rb.Count; i++)
                        {

                            if (rb[i].Isim == isimorsoyisim || rb[i].Soyisim == isimorsoyisim)
                            {
                                Console.WriteLine("Arama Sonuçlarınız:\n**********************************************\nisim: {0} soyisim: {1}  telefon numara: {2}", rb[i].Isim, rb[i].Soyisim, rb[i].Numara);
                                break;
                            }

                        }

                    }
                    if (secim2 == 2)
                    {
                        Console.Write("Lütfen aramak istediğiniz kişinin numarısını giriniz:");
                        int numara2 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < rb.Count; i++)
                        {

                            if (rb[i].Numara == numara2)
                            {
                                Console.WriteLine("Arama Sonuçlarınız:\n**********************************************\nisim: {0} soyisim: {1}  telefon numara: {2}", rb[i].Isim, rb[i].Soyisim, rb[i].Numara);
                            }

                        }

                    }

                    secim = -1;
                    
                }
                if (secim == 0)
                {

                    break;
                }
            }
            
        }
        class rehber
        {
            public string Isim { get; set; }
            public string Soyisim { get; set; }
            public int Numara { get; set; }           
        }
    }
}
