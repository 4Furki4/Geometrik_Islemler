using System;
namespace Geometrik_Islemler
{
    public class Geometrik_Islemler
    {
        Konsol_Islemleri konsol= new Konsol_Islemleri();
        public double CevreHesaplama(int[] arr, string sekil)
        {
            double cevre=0;
            if (sekil!="Silindir" && sekil!= "Daire")
            {
                foreach (var item in arr)
                {
                    cevre+=item;
                }
            }else if (sekil=="Silindir")
            {
                cevre= ((Math.PI*arr[0])*2)+(((Math.PI*arr[0])*2)+arr[1])*2;
            }
            else if (sekil=="Daire")
            {
                cevre=((Math.PI*arr[0])*2);
            }
            
            return cevre;
        }
        public double AlanHesaplama(int[] arr,string sekil)
        {
            double alan =1;
            if (sekil=="Kare")
            {
                alan=Math.Pow(arr[0],2);
            }else if(sekil=="Dikdörtgen")
            {
                alan = arr[0]*arr[1];
            }else if (sekil=="Küp")
            {
                alan=6*(Math.Pow(arr[0],2));
            }
            else if (sekil=="Silindir") // Alan formülü 2 π.r2+ 2πrh
            {
                alan = (2*(Math.PI*Math.Pow(arr[0],2))+ 2*((Math.PI*arr[0]*arr[1])));
            }else if (sekil== "Daire")
            {
                alan = Math.PI*Math.Pow(arr[0],2);
            }
            else if (sekil== "Üçgen")
            {
                alan = (arr[2]*arr[3])/2;
            }
            return alan;
        }

        public double HacimHesaplama(int[] arr, string sekil)
        {
            
            double hacim=1;
            switch (sekil)
            {
                case "Silindir":
                hacim=Math.PI*Math.Pow(arr[0],2)*arr[1]; 
                break;
                case "Küp":
                hacim=Math.Pow(arr[0],3);
                break;
            }
            return hacim; 
        }
    }
}