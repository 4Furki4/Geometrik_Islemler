using System;
namespace Geometrik_Islemler
{
    public class Konsol_Islemleri
    {
        // Geometrik şekil - kenar bilgileri - hesaplanacak işlem 
        public void IlkMesaj()
        {
            System.Console.WriteLine("Lütfen kullanmak istediğiniz geometrik şekli seçiniz:");
            System.Console.WriteLine("Kare(1)\nDikdörtgen(2)\nÜçgen(3)\nDaire(4)\nKüp(5)\nSilindir(6)\nCevap:");
        }
        public string SekilBelirleme()
        {
            int input = int.Parse(Console.ReadLine());
            string Sekil="";
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
    }
}