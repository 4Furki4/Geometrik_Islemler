using System;
namespace Geometrik_Islemler
{
    public class Geometrik_Islemler
    {
        Konsol_Islemleri konsol= new Konsol_Islemleri();
        public double CevreHesaplama(int[] arr)
        {
            double cevre=0;
            if (konsol.SekilBelirleme()!="Silindir" && konsol.SekilBelirleme()!= "Daire")
            {
                foreach (var item in arr)
                {
                    cevre+=item;
                }
            }else if (konsol.SekilBelirleme()=="Silindir")
            {
                cevre= ((Math.PI*arr[0])*2)+(((Math.PI*arr[0])*2)+arr[1])*2;
            }
            else if (konsol.SekilBelirleme()=="Daire")
            {
                cevre=((Math.PI*arr[0])*2);
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