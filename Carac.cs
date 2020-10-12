using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PremierTest
{
    class Carac
    {
        public int ConfigurerCarac()
        {
            Lanceur PremierLancéD6 = new Lanceur();
            Lanceur DeuxièmeLancéD6 = new Lanceur();
            Lanceur TroisièmeLancéD6 = new Lanceur();
            Lanceur QuatrièmeLancéD6 = new Lanceur();
            int Caracteristique;
            int PremierLancé = PremierLancéD6.Lanceur1D6();
            int DeuxiemeLancé = DeuxièmeLancéD6.Lanceur1D6();
            int TroisiemeLancé = TroisièmeLancéD6.Lanceur1D6();
            int QuatriemeLancé = QuatrièmeLancéD6.Lanceur1D6();

            Console.WriteLine("Les résultats des lancés sont: {0}, {1}, {2}, {3}", PremierLancé, DeuxiemeLancé, TroisiemeLancé, QuatriemeLancé);

            // DropLowest.

            int[] ValeurDesLancés = { PremierLancé, DeuxiemeLancé, TroisiemeLancé, QuatriemeLancé };
            Array.Sort(ValeurDesLancés);
            Console.WriteLine("{0} Est la valeure de lancé la plus basse des quatres lancés.", ValeurDesLancés[0]);

            Caracteristique = ValeurDesLancés[1] + ValeurDesLancés[2] + ValeurDesLancés[3];
            return Caracteristique;
        }
    }
}
