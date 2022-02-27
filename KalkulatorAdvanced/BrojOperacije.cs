using System;
using System.Diagnostics;

namespace KalkulatorAdvanced
{
    internal static class Operacije
    {
        public static Broj Sabiranje(Broj a, Broj b)        //sabira 2 pozitivna broja
        {
            Debug.WriteLine(a.zarez);
            Debug.WriteLine(b.zarez);

            int temp = a.zarez - b.zarez;

            for (int i = 0; i < temp; i++)
            {
                b.vrednost.Insert(0, 0);
                b.zarez++;
            }
            temp = b.zarez - a.zarez;

            for (int i = 0; i < temp; i++)
            {
                
                

                a.vrednost.Insert(0, 0);
                a.zarez++;
            }

            Debug.WriteLine(a.PretvoriUString());
            Debug.WriteLine(b.PretvoriUString());

            for (int i = 0; i < a.vrednost.Count - b.vrednost.Count; i++) b.vrednost.Add(0);
            for (int i = 0; i < b.vrednost.Count - a.vrednost.Count; i++) a.vrednost.Add(0);

            a.brCifara = a.vrednost.Count;
            b.brCifara = b.vrednost.Count;

            Broj rezultat = new Broj(a.brCifara, a.zarez, true);
            int cuva = 0;
            for (int i = a.brCifara - 1; i >= 0; i--)
            {
                rezultat.vrednost.Insert(0, Convert.ToSByte(cuva + a.vrednost[i] + b.vrednost[i]));

                cuva = 0;
                if (rezultat.vrednost[0] > 9)
                {
                    rezultat.vrednost[0] -= 10;
                    cuva = 1;
                }
            }

            if (cuva == 1)
            {
                rezultat.vrednost.Insert(0, 1);
                rezultat.zarez = a.zarez + 1;
                rezultat.brCifara = a.brCifara + 1;
            }
            else
            {
                rezultat.zarez = a.zarez;
                rezultat.brCifara = a.brCifara;
            }

            rezultat.UkloniNule();
            return rezultat;
        }

        public static Broj Oduzimanje(Broj a, Broj b)           //oduzima 2 pozitivna broja
        {

            int temp = a.zarez - b.zarez;

            for (int i = 0; i < temp; i++)
            {
                b.vrednost.Insert(0, 0);
                b.zarez++;
            }
            temp = b.zarez - a.zarez;
            for (int i = 0; i < temp; i++)
            {
                a.vrednost.Insert(0, 0);
                a.zarez++;
            }

            for (int i = 0; i < a.vrednost.Count - b.vrednost.Count; i++) b.vrednost.Add(0);
            for (int i = 0; i < b.vrednost.Count - a.vrednost.Count; i++) a.vrednost.Add(0);

            a.brCifara = a.vrednost.Count;
            b.brCifara = b.vrednost.Count;

            Broj rezultat = new Broj(a.brCifara, a.zarez, true);

            bool aVeceOdB = true;
            bool aVeceOdBInitialized = false;
            for (int i = 0; i < a.brCifara; i++)
            {
                if (a.vrednost[i] > b.vrednost[i])
                {
                    aVeceOdB = true;
                    aVeceOdBInitialized = true;
                    break;
                }
                else if (b.vrednost[i] > a.vrednost[i])
                {
                    aVeceOdB = false;
                    aVeceOdBInitialized = true;
                    break;
                }
            }
            if (aVeceOdBInitialized == false)
            {
                rezultat.PretvoriUBroj("0");
                return rezultat;
            }


            if (aVeceOdB == false)
            {
                rezultat = Oduzimanje(b, a);
                rezultat.pozitivan = false;
                Debug.WriteLine(rezultat.pozitivan);
                return rezultat;
            }

            rezultat.zarez = a.zarez;
            rezultat.brCifara = a.brCifara;

            int pozajmljeno = 0;

            for (int i = a.vrednost.Count - 1; i >= 0; i--)
            {
                if (a.vrednost[i] - pozajmljeno >= b.vrednost[i])
                {
                    rezultat.vrednost.Insert(0, Convert.ToSByte(a.vrednost[i] - pozajmljeno - b.vrednost[i]));
                    pozajmljeno = 0;
                }
                else
                {
                    a.vrednost[i] = Convert.ToSByte(10 + a.vrednost[i]);
                    rezultat.vrednost.Insert(0, Convert.ToSByte(a.vrednost[i] - pozajmljeno - b.vrednost[i]));
                    pozajmljeno = 1;
                }
            }

            rezultat.UkloniNule();
            return rezultat;
        }

        public static Broj Mnozenje(Broj a, Broj b)
        {
            Broj rezultat = new Broj();

            rezultat.brCifara = a.brCifara + b.brCifara - 1;
            rezultat.zarez = a.zarez + b.zarez - 1;

            for (int i = 0; i < rezultat.brCifara; i++) rezultat.vrednost.Add(0);

            if (a.pozitivan == b.pozitivan) rezultat.pozitivan = true;
            else rezultat.pozitivan = false;

            int pamti = 0;
            for (int i = a.brCifara - 1; i >= 0; i--)
            {
                for (int j = b.brCifara - 1; j >= 0; j--)
                {
                    int tempRez = (a.vrednost[i] * b.vrednost[j]) + rezultat.vrednost[i + j];

                    rezultat.vrednost[i + j] = Convert.ToSByte(tempRez % 10);

                    if (i + j != 0) rezultat.vrednost[i + j - 1] = Convert.ToSByte(rezultat.vrednost[i + j - 1] + tempRez / 10);
                    else pamti += tempRez / 10;
                }
            }

            if (pamti > 0)
            {
                rezultat.brCifara++;
                rezultat.zarez++;

                rezultat.vrednost.Insert(0, Convert.ToSByte(pamti));
            }

            rezultat.UkloniNule();

            return rezultat;
        }

        public static Broj Deljenje(Broj a, Broj b)
        {
            Broj rezultat = new Broj();

            if (a.pozitivan == b.pozitivan) rezultat.pozitivan = true;
            else rezultat.pozitivan = false;

            rezultat.PretvoriUBroj(Convert.ToString(a.PretvoriUDecimal() / b.PretvoriUDecimal()));

            return rezultat;
        }

        public static Broj PretvoriUBroj(string rimski)
        {
            char[] rimskiSimboli = { 'M', 'D', 'C', 'L', 'X', 'V', 'I', '0' };
            int[] intSimboli = { 1000, 500, 100, 50, 10, 5, 1, 0 };

            rimski += "0";

            int tr = 0;
            int rezultat = 0;

            for (int i = 0; i < rimski.Length - 1; i++)
            {
                tr += intSimboli[Array.IndexOf(rimskiSimboli, rimski[i])];

                int naredni = intSimboli[Array.IndexOf(rimskiSimboli, rimski[i + 1])];

                if (naredni > tr)
                {
                    rezultat -= tr;
                    tr = 0;
                }
                else if (naredni < tr)
                {
                    rezultat += tr;
                    tr = 0;
                }
            }
            Broj rez = new Broj(rezultat.ToString());
            return rez;
        }
    }
}