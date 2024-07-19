using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas3
{
    internal class Masyvai
    {
        public static void Main(string[] args)
        {
            int[] Masyvas1 = new[] { 1, 2, 3, 4, 5 };
            int[] Masyvas2 = new[] { 6, 222, 3, 8, 543, 2, 90, 17, 84 };
            int[] Masyvas3 = new[] { 0, 0, 0, 0, 5, 0, 0, 0, 0 };

            //PirmojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);

            //AntrojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);

            //TreciojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);

            //KetvirtojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);

            //PenktojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);

            //SestojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);

            SeptintojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);
        }

        /// <summary>
        /// Pirmo elemento nuskaitymas ir išvedimas
        /// </summary>
        /// <param name="Masyvas1"></param>
        /// <param name="Masyvas2"></param>
        /// <param name="Masyvas3"></param>
        public static void PirmojiUzduotis(ref int[] Masyvas1, ref int[] Masyvas2, ref int[] Masyvas3)
        {
            Console.WriteLine($"Pirmasis elementas pirmajame masyve: {Masyvas1[0]}");
            Console.WriteLine($"Pirmasis elementas antrajame masyve: {Masyvas2[0]}");
            Console.WriteLine($"Pirmasis elementas treciajame masyve: {Masyvas3[0]}");
        }

        /// <summary>
        /// Antro elemento keitimas
        /// </summary>
        /// <param name="Masyvas1"></param>
        /// <param name="Masyvas2"></param>
        /// <param name="Masyvas3"></param>
        public static void AntrojiUzduotis(ref int[] Masyvas1, ref int[] Masyvas2, ref int[] Masyvas3)
        {
            int Number;

            Console.WriteLine($"Antrasis elementas pirmajame masyve: {Masyvas1[1]}");
            Console.WriteLine($"Antrasis elementas antrajame masyve: {Masyvas2[1]}");
            Console.WriteLine($"Antrasis elementas treciajame masyve: {Masyvas3[1]}");

            Console.WriteLine("Iveskite kokio antrojo elemento norite pirmajame masyve:");
            if (int.TryParse(Console.ReadLine(), out Number))
                Masyvas1[1] = Number;
            else
                Console.WriteLine("Neteisinga ivestis!");

            Console.WriteLine("Iveskite kokio antrojo elemento norite antrajame masyve:");
            if (int.TryParse(Console.ReadLine(), out Number))
                Masyvas2[1] = Number;
            else
                Console.WriteLine("Neteisinga ivestis!");

            Console.WriteLine("Iveskite kokio antrojo elemento norite antrajame masyve:");
            if (int.TryParse(Console.ReadLine(), out Number))
                Masyvas3[1] = Number;
            else
                Console.WriteLine("Neteisinga ivestis!");

            Console.WriteLine($"Antrasis elementas pirmajame masyve: {Masyvas1[1]}");
            Console.WriteLine($"Antrasis elementas antrajame masyve: {Masyvas2[1]}");
            Console.WriteLine($"Antrasis elementas treciajame masyve: {Masyvas3[1]}");
        }

        /// <summary>
        /// Masyvo ilgio nustatymas ir išvedimas
        /// </summary>
        /// <param name="Masyvas1"></param>
        /// <param name="Masyvas2"></param>
        /// <param name="Masyvas3"></param>
        public static void TreciojiUzduotis(ref int[] Masyvas1, ref int[] Masyvas2, ref int[] Masyvas3)
        {
            Console.WriteLine($"Pirmojo masyvo ilgis: {Masyvas1.Length}");
            Console.WriteLine($"Antrojo masyvo ilgis: {Masyvas2.Length}");
            Console.WriteLine($"Treciojo masyvo ilgis: {Masyvas3.Length}");
        }

        /// <summary>
        /// Trečio elemento nuskaitymas ir išvedimas
        /// </summary>
        /// <param name="Masyvas1"></param>
        /// <param name="Masyvas2"></param>
        /// <param name="Masyvas3"></param>
        public static void KetvirtojiUzduotis(ref int[] Masyvas1, ref int[] Masyvas2, ref int[] Masyvas3)
        {
            Console.WriteLine($"Treciasis elementas pirmajame masyve: {Masyvas1[2]}");
            Console.WriteLine($"Treciasis elementas antrajame masyve: {Masyvas2[2]}");
            Console.WriteLine($"Treciasis elementas treciajame masyve: {Masyvas3[2]}");
        }

        /// <summary>
        /// Paskutinio elemento nuskaitymas ir išvedimas
        /// </summary>
        /// <param name="Masyvas1"></param>
        /// <param name="Masyvas2"></param>
        /// <param name="Masyvas3"></param>
        public static void PenktojiUzduotis(ref int[] Masyvas1, ref int[] Masyvas2, ref int[] Masyvas3)
        {
            Console.WriteLine($"Paskutinis elementas pirmajame masyve: {Masyvas1[Masyvas1.Length - 1]}");
            Console.WriteLine($"Paskutinis elementas antrajame masyve: {Masyvas2[Masyvas2.Length - 1]}");
            Console.WriteLine($"Paskutinis elementas treciajame masyve: {Masyvas3[Masyvas3.Length - 1]}");
        }

        /// <summary>
        /// Vidurio elemento nuskaitymas ir išvedimas
        /// </summary>
        /// <param name="Masyvas1"></param>
        /// <param name="Masyvas2"></param>
        /// <param name="Masyvas3"></param>
        public static void SestojiUzduotis(ref int[] Masyvas1, ref int[] Masyvas2, ref int[] Masyvas3)
        {
            Console.WriteLine($"Paskutinis elementas pirmajame masyve: {Masyvas1[Masyvas1.Length / 2]}");
            Console.WriteLine($"Paskutinis elementas antrajame masyve: {Masyvas2[Masyvas2.Length / 2]}");
            Console.WriteLine($"Paskutinis elementas treciajame masyve: {Masyvas3[Masyvas3.Length / 2]}");
        }

        /// <summary>
        /// Masyvo elementų sudėjimas ir rezultato išvedimas
        /// </summary>
        /// <param name="Masyvas1"></param>
        /// <param name="Masyvas2"></param>
        /// <param name="Masyvas3"></param>
        public static void SeptintojiUzduotis(ref int[] Masyvas1, ref int[] Masyvas2, ref int[] Masyvas3)
        {
            int Rez = 0;
            int Idx = 0;

            MasyvoSudetis(ref Masyvas1, ref Rez, ref Idx);
            Console.WriteLine($"Pirmojo masyvo elementu sudeties rezultatas: {Rez}");
            Rez = 0;
            Idx = 0;
            MasyvoSudetis(ref Masyvas2, ref Rez, ref Idx);
            Console.WriteLine($"Antrojo masyvo elementu sudeties rezultatas: {Rez}");
            Rez = 0;
            Idx = 0;
            MasyvoSudetis(ref Masyvas3, ref Rez, ref Idx);
            Console.WriteLine($"Treciojo masyvo elementu sudeties rezultatas: {Rez}");
        }

        /// <summary>
        /// Sudeda masyvo elementus po viena
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Rezultatas"></param>
        /// <param name="Index"></param>
        public static void MasyvoSudetis(ref int[] Masyvas, ref int Rezultatas, ref int Index)
        {
            if (Index < Masyvas.Length)
            {
                Rezultatas += Masyvas[Index];
                ++Index;
                CheckIfShouldContinue(ref Masyvas, ref Rezultatas, ref Index);
            }
        }

        /// <summary>
        /// Patikrina, ar reikia testi sudejima
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Rezultatas"></param>
        /// <param name="Index"></param>
        public static void CheckIfShouldContinue(ref int[] Masyvas, ref int Rezultatas, ref int Index)
        {
            if (Index < Masyvas.Length)
                MasyvoSudetis(ref Masyvas, ref Rezultatas, ref Index);
        }
    }
}
