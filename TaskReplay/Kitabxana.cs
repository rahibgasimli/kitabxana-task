namespace TaskReplay
{
    class Kitabxana
    {
        private Kitab[] _kitablar;

        public Kitabxana()
        {
            _kitablar = new Kitab[]
            {
                new Kitab()
                {
                    Ad="Menim Payim",
                    Yazici="Perinus Seni",
                    YazildigiIl=new DateTime(2010,09,25),
                    Janr="Drama"
                },
                new Kitab()
                {
                    Ad="10 Zenci Balasi",
                    Yazici="Aqata Kristin",
                    YazildigiIl=new DateTime(2005,12,18),
                    Janr="Dedektiv"
                },
                new Kitab()
                {
                    Ad="Serlok Holmes",
                    Yazici="Artur Konan Doyl",
                    YazildigiIl=new DateTime(1995,03,07),
                    Janr="Dedektiv"
                },                new Kitab()
                {
                    Ad="Serq ekspressinde qetl",
                    Yazici="Aqata Kristin",
                    YazildigiIl=new DateTime(2005,12,18),
                    Janr="Dedektiv"
                }
            };
        }


        public void KitablariGoster()
        {
            int say = 1;
            foreach (var kitab in _kitablar)
            {
                Console.WriteLine("============================================");
                Console.WriteLine($"Nömrə: {say}");
                Console.WriteLine($"Adı: {kitab.Ad}");
                Console.WriteLine($"Yazıçı: {kitab.Yazici}");
                Console.WriteLine($"Janrı: {kitab.Janr}");
                Console.WriteLine($"Yazıldığı tarixi: {kitab.YazildigiIl}");
                Console.WriteLine("============================================");
                say++;
            }
        }
        public void KitabElaveEt(Kitab elaveEdilecek)
        {
            _kitablar = _kitablar.Append(elaveEdilecek).ToArray();
        }

        public void KitabKirayeVer(int silinecekNomre)
        {
            Kitab[] yeniKitablar = new Kitab[0];
            for (int i = 0; i < _kitablar.Length; i++)
            {
                if (i == silinecekNomre - 1)
                    continue;
                yeniKitablar = yeniKitablar.Append(_kitablar[i]).ToArray();
            }

            _kitablar = yeniKitablar;


        }


        public  Kitab[] AdinaGoreAxtarisEt(string axtarisAdi)
        {
            Kitab[] tapilanKitablar = new Kitab[0];

            foreach (var kitab in _kitablar)
            {
                if (axtarisAdi == kitab.Ad)
                {
                    tapilanKitablar=tapilanKitablar.Append(kitab).ToArray();
                }
            }
            return tapilanKitablar;
        }


        public Kitab[] YaziciyaGoreAxtarisEt(string axtarisYazici)
        {
            Kitab[] tapilanKitablar = new Kitab[0];

            foreach (var kitab in _kitablar)
            {
                if (axtarisYazici == kitab.Yazici)
                {
                    tapilanKitablar = tapilanKitablar.Append(kitab).ToArray();
                }
            }
            return tapilanKitablar;

        }

        public Kitab[] JanraGoreAxtarisEt(string axtarisJanri)
        {
            Kitab[] tapilanlar = new Kitab[0];
            
            foreach(var kitab in _kitablar)
            {
                if (axtarisJanri == kitab.Janr)
                {
                    tapilanlar=tapilanlar.Append(kitab).ToArray();
                }
               
            }
            return tapilanlar;
        }



    }
}
