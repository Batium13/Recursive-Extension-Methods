using System;

namespace Recursive_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //**** Recursion Methods***//

            Islemler sonuc = new();
            Console.WriteLine(sonuc.Expo(3,4));

            // **** Extension Methods **** //
            string ifade = "Batuhan Altinel";
            bool result = ifade.CheckSpaces();

            Console.WriteLine(result);
            // if(result)
            //     Console.WriteLine(ifade.RemoveWhiteSpaces);
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeLowerCase());

            Console.WriteLine(ifade.GetFirstCharacter());

            int[] dizi ={9,3,2,6,5,4,3,1};
            dizi.SortArray();
            dizi.EkranaYazdir();
            
            int sayi =28;
            Console.WriteLine(sayi.IsEvenNumber());
        }
    }

    public class Islemler{

        public int Expo(int sayi,int üst){
            
            if(üst<2)
            return sayi;

            return Expo(sayi,üst-1) * sayi;
        }
    }
       
       
        ////****** Extension Methods ***////
    public static class Extension{
        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        }
        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }
        public static int[] SortArray (this int[] param){
            Array.Sort(param);
            return param;
        } 
        public static void EkranaYazdir(this int[] param){
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param){
            return param%2==0;
        }
        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1);
        }

    }
}
