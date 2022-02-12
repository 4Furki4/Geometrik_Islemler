namespace Geometrik_Islemler
{
    public class Geometrik_Islemler
    {
        Konsol_Islemleri konsol= new Konsol_Islemleri();
        public int CevreHesaplama(int[] arr)
        {
            int cevre=0;
            foreach (var item in arr)
            {
                cevre+=item;
            }
            return cevre;
        }
        public int AlanHesaplama(int[] arr)
        {
            int alan =1;
            if (konsol.SekilBelirleme()!="Silindir" && konsol.SekilBelirleme()!= "Daire")
            {
                foreach (var item in arr)
                {
                    alan*=item;
                }
            }
            return alan;
        }
    }
}