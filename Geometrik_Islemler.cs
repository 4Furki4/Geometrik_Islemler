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
        public double AlanHesaplama(int[] arr)
        {
            double alan =1;
            if (konsol.SekilBelirleme()!="Silindir" && konsol.SekilBelirleme()!= "Daire" && konsol.SekilBelirleme()!= "Üçgen")
            {
                foreach (var item in arr)
                {
                    alan*=item;
                }
            }else if (konsol.SekilBelirleme()=="Silindir") // Alan formülü 2 π.r2+ 2πrh
            {
                alan = (2*(Math.PI*Math.Pow(arr[0],2))+ 2*((Math.PI*arr[0]*arr[1])));
            }else if (konsol.SekilBelirleme()== "Daire")
            {
                alan = Math.PI*Math.Pow(arr[0],2);
            }
            else if (konsol.SekilBelirleme()== "Üçgen")
            {
                alan = (arr[2]*arr[3])/2;
            }
            return alan;
        }
    }
}