using System;
namespace Geometrik_Islemler
{
    public class Konsol_Islemleri
    {   string Sekil="";
        // Geometrik şekil - kenar bilgileri - hesaplanacak işlem 
        public void IlkMesaj()
        {
            System.Console.WriteLine("Lütfen kullanmak istediğiniz geometrik şekli seçiniz:");
            System.Console.Write("Kare(1)\nDikdörtgen(2)\nÜçgen(3)\nDaire(4)\nKüp(5)\nSilindir(6)\nCevap:");
        }
        public string SekilBelirleme()
        {
            int input = int.Parse(Console.ReadLine());
            Sekil="";
                switch (input)
                {
                    case 1:
                        Sekil="Kare";
                        break;
                    case 2:
                        Sekil="Dikdörtgen";
                        break;
                    case 3:
                        Sekil="Üçgen";
                        break;
                    case 4:
                        Sekil="Daire";
                        break;
                    case 5:
                        Sekil="Küp";
                        break;
                    case 6:
                        Sekil="Silindir";
                        break;
                }
            return Sekil;
        }
        public void UzunlukMesajı() // Uzunlukları isteyen mesajı, gerekli talimatları yazdıran metot.
        {
            System.Console.WriteLine("Lütfen talimatlara uygun bir şekilde girmek istediğiniz kenar uzunluklarını yazınız:");
            System.Console.WriteLine("Her uzunluğun arasına boşluk bırakınız!");
            System.Console.WriteLine("Kare ve küp için tek kenarın, dikdörtgen için 2 kenarın, üçgen için üç kenarın, daire için yarı çapının, silindir için  yarı çapın ve yüksekliğin uzunluğunu yazınız.");
        }
        public int[] KenarUzunlukları() //kenar uzunluklarını string olarak aldık ve bunları int değere dönüştürüp int dizide depoladık.
        {
            
            string s= Console.ReadLine();
            string[] arr =s.Split(" ");
            int[] uzunluklar= new int[4];
            int i=0;
                foreach (var item in arr)           
                {
                    uzunluklar[i]=int.Parse(item);
                    i++;
                }
            return uzunluklar;
        }
        public void Islem_Mesajı()
        {
            System.Console.WriteLine("(Not: 2D cisimler için hacim geçerli değildir) Lütfen yapmak istediğiniz işlemi seçiniz:");
            System.Console.Write("Çevre(1)\nAlan(2)\nHacim(3)\nCevap:");
        }
        public string SecilenIslem() //Main metodunda buradan gelen işlem tipine göre Geometrik_Islemler sınıfından gereken metot çağırılacak.
        {
            int input= int.Parse(Console.ReadLine());
            string islem ="";
            switch (input)
            {
                case 1:
                    islem="Çevre";
                    break;
                case 2:
                    islem="Alan";
                    break;
                case 3:
                    islem="Hacim";
                    break;
            }
            return islem;
        }


    }
}
