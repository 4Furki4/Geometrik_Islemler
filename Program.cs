using System;

namespace Geometrik_Islemler
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri konsol = new Konsol_Islemleri();
            Geometrik_Islemler Islemler= new Geometrik_Islemler();
            konsol.IlkMesaj();
            string sekil= konsol.SekilBelirleme();
            string Islem= konsol.SecilenIslem();
            int[] Uzunluklar = konsol.KenarUzunlukları();
            switch (Islem)
            {
                case "Çevre":
                konsol.SonucuYazdırma(sekil,Islem,Islemler.CevreHesaplama(Uzunluklar,sekil));
                break;
                case "Alan":
                konsol.SonucuYazdırma(sekil,Islem,Islemler.AlanHesaplama(Uzunluklar,sekil));
                break;
                case "Hacim":
                konsol.SonucuYazdırma(sekil,Islem,Islemler.HacimHesaplama(Uzunluklar,sekil));
                break;
            }            
        }
    }
}
