using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KalkulatorAdvanced
{
    public class Broj
    {
        public bool pozitivan;
        public List<sbyte> vrednost;            //npr 1234,5678
        public int brCifara;                    //brCifara = 8
        public int zarez;                        //nula = 4

        public Broj()
        {
            vrednost = new List<sbyte>();
        }

        public Broj(int brCifara, int zarez, bool pozitivan)           //public sa svim vrednostima
        {
            vrednost = new List<sbyte>();
            this.pozitivan = pozitivan;
            this.zarez = zarez;
            this.brCifara = brCifara;
        }

        public Broj(string ulaz)                    //public sa stringom koji se pretvara u broj
        {
            vrednost = new List<sbyte>();
            PretvoriUBroj(ulaz);
        }

        public void PretvoriUBroj(string ulaz)      //funkcija za pretvaranje stringa u broj
        {
            if (ulaz[0] == '-')
            {
                pozitivan = false;
                ulaz.Remove(0, 1);
            }
            else pozitivan = true;

            zarez = -1;

            for (int i = 0; i < ulaz.Length; i++)
            {
                if (Convert.ToString(ulaz[i]) == ",") zarez = i;
                else
                {
                    vrednost.Add(Convert.ToSByte(ulaz[i] - '0'));
                }
            }
            if (zarez == -1)
            {
                brCifara = ulaz.Length;
                zarez = brCifara;
            }
            else brCifara = ulaz.Length - 1;

            brCifara = vrednost.Count;
        }

        public string PretvoriUString()             //funkcija za pretvaranje broja u string
        {
            string output = "";
            for (int i = 0; i < vrednost.Count; i++)
            {
                if (i == zarez) output = output + ",";
                output += Convert.ToString(vrednost[i]);
            }

            return output;
        }

        public decimal PretvoriUDecimal()           //funkcija za pretvaranje broja u decimal
        {
            decimal rezultat = 0;

            for (int i = 0; i < zarez; i++)
            {
                rezultat = 10 * rezultat + vrednost[i];
            }
            for (int i = zarez; i < brCifara; i++)
            {
                rezultat += Convert.ToDecimal(vrednost[i]) / 10;
            }

            return rezultat;
        }

        public void UkloniNule()                                //0012,3400 > 12,34
        {
            int startBr = -1;                                   //0012,3400
            for (int i = 0; i < zarez - 1; i++)                 //  ^
            {
                if (vrednost[i] != 0)
                {
                    startBr = i;
                    break;
                }
            }
            if (startBr == -1) startBr = zarez - 1;

            int endBr = -1;                                     //0012,3400
            for (int i = vrednost.Count - 1; i >= zarez; i--)   // ^    ^
            {
                if (vrednost[i] != 0)
                {
                    endBr = i + 1;
                    break;
                }
            }
            if (endBr == -1) endBr = zarez;

            int j = 0;
            while (j < brCifara)
            {
                if (j < startBr)
                {
                    Debug.WriteLine(j);
                    zarez--;
                    startBr--;
                    endBr--;
                    brCifara--;
                    vrednost.RemoveAt(j);   //
                }
                else if (j < endBr) j++;
                else
                {
                    vrednost.RemoveAt(j);
                    brCifara--;
                    endBr--;
                    startBr--;
                }
            }
        }

        public string PretvoriURimski()
        {
            string[] rimskiSimboli = { "MMM", "MM", "M", "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C", "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X", "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };
            int[] intSimboli = { 3000, 2000, 1000, 900, 800, 700, 600, 500, 400, 300, 200, 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int br = Convert.ToInt32(PretvoriUString());
            int i = 0;

            string rezultat = "";

            while (br != 0)
            {
                if (br >= intSimboli[i])
                {
                    br -= intSimboli[i];
                    rezultat = rezultat + rimskiSimboli[i];
                }
                else i++;
            }
            return rezultat;
        }
    }
}