//Ekrana cixaranda Azerbaycan herfleri
using System.ComponentModel.Design;
using TaskReplay;

Console.OutputEncoding = System.Text.Encoding.UTF8;
//Deyer alanda Azerbaycan herfleri
Console.InputEncoding = System.Text.Encoding.UTF8;

string loginAd = "admin";
string loginPass = "admin123";

while (true)
{
    Console.WriteLine("Istifadeci adi daxil edin");
    string inputAd = Console.ReadLine();
    Console.WriteLine("Password daxil edin");
    string inputPass =Console.ReadLine();
    if(inputPass ==loginPass &&  inputAd == loginAd)
    {
        Console.WriteLine("Girish olundu");
        Thread.Sleep(1000);
        Console.Clear();
        break;
    }
}


menu:
{
    Console.WriteLine("Emeliyyatlardan birini secin");
    Console.WriteLine("1) Kitabların siyahısını ekrana çıxart");
    Console.WriteLine("2) Kitab əlavə et ");
    Console.WriteLine("3) Kitabı kirayə ver ");
    Console.WriteLine("4) Kitabxanada axtarış et");
}

int secim;

if(int.TryParse(Console.ReadLine(), out secim))
{
    Kitabxana menimKitabxanam= new Kitabxana();

    switch (secim)
    {
        case 1:
            menimKitabxanam.KitablariGoster();
            break;
        case 2:
            Console.WriteLine("Kitabin adini daxil edin");
            string kitabAdi=Console.ReadLine();
            Console.WriteLine("Kitabin yazicisini daxil edin");
            string kitabYazici = Console.ReadLine();
            Console.WriteLine("Kitabin janrini daxil edin");
            string kitabJanri = Console.ReadLine();
            Console.WriteLine("Kitabin yazildigi ili daxil edin");
            int il = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitabin yazildigi ayi daxil edin");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitabin yazildigi gunu daxil edin");
            int gun = Convert.ToInt32(Console.ReadLine());
            DateTime kitabinTarixi = new DateTime(il, ay, gun);


            Kitab menimKitabim=new Kitab();
            menimKitabim.Ad = kitabAdi;
            menimKitabim.Yazici = kitabYazici;
            menimKitabim.Janr = kitabJanri;
            menimKitabim.YazildigiIl = kitabinTarixi;

            menimKitabxanam.KitabElaveEt(menimKitabim);
            Console.WriteLine("Kitab elave edildi");
            menimKitabxanam.KitablariGoster();
            break;
        case 3:
            menimKitabxanam.KitablariGoster();
            Console.WriteLine("Hansi kitabi goturmek isteyirsiz?(Nomresini daxil edin)");
            int nomre = Convert.ToInt32(Console.ReadLine());
            menimKitabxanam.KitabKirayeVer(nomre);
            Console.WriteLine("Xos oxumalar");
            menimKitabxanam.KitablariGoster();
            break;
        case 4:
        axtarisMenu:
            {
                Console.WriteLine("Axtaris edilecek kriteryani secin");
                Console.WriteLine("1) Adina gore");
                Console.WriteLine("2) Yaziciya gore");
                Console.WriteLine("3) Janra Gore");
            }

            int axtarisSecimi;

            if(int.TryParse(Console.ReadLine(), out axtarisSecimi))
            {
                switch(axtarisSecimi) { 
                    case 1:
                        Console.WriteLine("Axtaris edeceyiniz adi daxil edin");
                        string ad = Console.ReadLine();
                        var kitablar = menimKitabxanam.AdinaGoreAxtarisEt(ad);
                        Console.WriteLine("Tapilan kitablar");

                        foreach (var kitab in kitablar)
                        {
                            Console.WriteLine("============================================");
                            Console.WriteLine($"Adı: {kitab.Ad}");
                            Console.WriteLine($"Yazıçı: {kitab.Yazici}");
                            Console.WriteLine($"Janrı: {kitab.Janr}");
                            Console.WriteLine($"Yazıldığı tarixi: {kitab.YazildigiIl}");
                            Console.WriteLine("============================================");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Axtaris edeceyiniz yaziciyi daxil edin");
                        string yazici = Console.ReadLine();
                        var tapilanlar = menimKitabxanam.YaziciyaGoreAxtarisEt(yazici);
                        Console.WriteLine("Tapilan kitablar");

                        foreach (var kitab in tapilanlar)
                        {
                            Console.WriteLine("============================================");
                            Console.WriteLine($"Adı: {kitab.Ad}");
                            Console.WriteLine($"Yazıçı: {kitab.Yazici}");
                            Console.WriteLine($"Janrı: {kitab.Janr}");
                            Console.WriteLine($"Yazıldığı tarixi: {kitab.YazildigiIl}");
                            Console.WriteLine("============================================");
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlish secim");
                        goto axtarisMenu;
                        break;
                    case 3:
                        Console.WriteLine("Axtaris edeceyiniz janri daxil edin");
                        string janr = Console.ReadLine();
                        var tapilanJanr = menimKitabxanam.JanraGoreAxtarisEt(janr);
                        Console.WriteLine("Tapilan kitablar");

                        foreach (var kitab in tapilanJanr)
                        {
                            Console.WriteLine("============================================");
                            Console.WriteLine($"Adı: {kitab.Ad}");
                            Console.WriteLine($"Yazıçı: {kitab.Yazici}");
                            Console.WriteLine($"Janrı: {kitab.Janr}");
                            Console.WriteLine($"Yazıldığı tarixi: {kitab.YazildigiIl}");
                            Console.WriteLine("============================================");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Yanlish format");
                goto axtarisMenu;
            }

            break;
        default:
            Console.WriteLine("Duzgun deyer daxil edin");
            Thread.Sleep(1000);
            Console.Clear();
            goto menu;
    }
}
else
{
    Console.WriteLine("Yanlish format daxil etdiniz");
    Thread.Sleep(1000);
    Console.Clear();
    goto menu;
}








