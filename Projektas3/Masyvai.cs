using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            //SeptintojiUzduotis(ref Masyvas1, ref Masyvas2, ref Masyvas3);

            //AstuntojiUzduotis();

            //DevintojiUzduotis();

            //DesimtojiUzduotis();

            //VienuoliktojiUzduotis();

            //DvyliktojiUzduotis();

            //TryliktojiUzduotis();
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

        /// <summary>
        /// Įveskite skaičių ir patikrinkite, ar jis yra masyve
        /// </summary>
        public static void AstuntojiUzduotis()
        {
            int[] Masyvas = new[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12, 13, 14, 16, 17, 18, 19 };
            
            int Idx = 0;
            Console.WriteLine("Dabartinis masyvas:");
            PrintArray(ref Masyvas, ref Idx);

            Console.WriteLine("Iveskite ieskoma skaiciu:");
            if (!int.TryParse(Console.ReadLine(), out int Value))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            if (Masyvas.Contains(Value))
                Console.WriteLine("Skaicius yra masyve");
            else
                Console.WriteLine("Skaiciaus nera masyve");
        }

        /// <summary>
        /// Masyvo spausdinimas
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Index"></param>
        public static void PrintArray(ref int[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
            {
                Console.WriteLine(Masyvas[Index]);
                ++Index;
                CheckIfShouldPrintMore(ref Masyvas, ref Index);
            }
        }

        /// <summary>
        /// Patikrina ar reikia testi spausdinima
        /// </summary>
        /// <param name="Masyvas"></param>
        /// <param name="Index"></param>
        public static void CheckIfShouldPrintMore(ref int[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
                PrintArray(ref Masyvas, ref Index);
        }

        public static void PrintArray(ref double[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
            {
                Console.WriteLine(Masyvas[Index]);
                ++Index;
                CheckIfShouldPrintMore(ref Masyvas, ref Index);
            }
        }

        public static void CheckIfShouldPrintMore(ref double[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
                PrintArray(ref Masyvas, ref Index);
        }

        public static void PrintArray(ref char[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
            {
                Console.WriteLine(Masyvas[Index]);
                ++Index;
                CheckIfShouldPrintMore(ref Masyvas, ref Index);
            }
        }

        public static void CheckIfShouldPrintMore(ref char[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
                PrintArray(ref Masyvas, ref Index);
        }

        public static void PrintArray(ref string[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
            {
                Console.WriteLine(Masyvas[Index]);
                ++Index;
                CheckIfShouldPrintMore(ref Masyvas, ref Index);
            }
        }

        public static void CheckIfShouldPrintMore(ref string[] Masyvas, ref int Index)
        {
            if (Index < Masyvas.Length)
                PrintArray(ref Masyvas, ref Index);
        }

        /// <summary>
        /// Įveskite indeksą ir pakeiskite to indekso elementą į naują reikšmę
        /// </summary>
        public static void DevintojiUzduotis()
        {
            double[] Masyvas = new[] { 1.5, 3.1, 3.847, 4.35, 6.82, 7.1, 8.76, 9.54, 11.89, 12.156, 13.795, 14.178, 16.94, 17.9, 18.48, 19.37 };

            int Idx = 0;
            Console.WriteLine("Dabartinis masyvas:");
            PrintArray(ref Masyvas, ref Idx);

            Console.WriteLine("Iveskite ieskomo elemento indeksa:");
            if (!int.TryParse(Console.ReadLine(), out int Index) || Index < 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            if (Index >= Masyvas.Length)
            {
                Console.WriteLine("Ivestas indeksas virsija masyvo ilgi!");
                return;
            }
            Console.WriteLine($"Dabartine sio elemento reiksme: {Masyvas[Index]}");
            Console.WriteLine("Iveskite nauja elemento reiksme:");
            if (!double.TryParse(Console.ReadLine(), out double Value))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Masyvas[Index] = Value;
            Console.WriteLine($"Nauja sio elemento reiksme: {Masyvas[Index]}");

            Idx = 0;
            Console.WriteLine("Dabartinis masyvas:");
            PrintArray(ref Masyvas, ref Idx);
        }

        /// <summary>
        /// Įveskite raidę ir patikrinkite, ar ji yra simbolių masyve
        /// </summary>
        public static void DesimtojiUzduotis()
        {
            char[] Masyvas = new[] {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P'};

            int Idx = 0;
            Console.WriteLine("Dabartinis masyvas:");
            PrintArray(ref Masyvas, ref Idx);

            Console.WriteLine("Iveskite ieskoma raide:");
            if (!char.TryParse(Console.ReadLine(), out char Value))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Value = char.ToUpper(Value);
            if (Masyvas.Contains(Value))
                Console.WriteLine("Raide yra masyve");
            else
                Console.WriteLine("Raides nera masyve");
        }


        public static void VienuoliktojiUzduotis()
        {
            string[] Masyvas = new[] { "As", "Tu", "Jis", "Ji", "Jie", "Jos" };

            int Idx = 0;
            Console.WriteLine("Dabartinis masyvas:");
            PrintArray(ref Masyvas, ref Idx);

            Console.WriteLine("Iveskite ieskoma eilute:");
            string Value = Console.ReadLine();
            if (Masyvas.Contains(Value))
                Console.WriteLine("Eilute yra masyve");
            else
                Console.WriteLine("Eilutes nera masyve");
        }

        public static void DvyliktojiUzduotis()
        {
            int[] Masyvas = new[] { 1, 2, 3, 4, 6, 7, 8, 9, 11, 12, 13, 14, 16, 17, 18, 19 };

            int Idx = 0;
            Console.WriteLine("Dabartinis masyvas:");
            PrintArray(ref Masyvas, ref Idx);

            Console.WriteLine("Iveskite pirmaji skaiciu:");
            if (!int.TryParse(Console.ReadLine(), out int Value1))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            Console.WriteLine("Iveskite antraji skaiciu:");
            if (!int.TryParse(Console.ReadLine(), out int Value2))
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            if (Masyvas.Contains(Value1 + Value2))
                Console.WriteLine("Skaiciu suma yra masyve");
            else
                Console.WriteLine("Skaiciu sumos nera masyve");
        }

        public static void TryliktojiUzduotis()
        {
            double[] Masyvas = new[] { 1.5, 3.1, 3.847, 4.35, 6.82, 7.1, 8.76, 9.54, 11.89, 12.156, 13.795, 14.178, 16.94, 17.9, 18.48, 19.37 };

            int Idx = 0;
            Console.WriteLine("Dabartinis masyvas:");
            PrintArray(ref Masyvas, ref Idx);

            Console.WriteLine("Iveskite indekso numeri:");
            if (!int.TryParse(Console.ReadLine(), out int Index) || Index < 0)
            {
                Console.WriteLine("Neteisinga ivestis!");
                return;
            }
            if (Index >= Masyvas.Length)
            {
                Console.WriteLine("Ivestas indeksas virsija masyvo ilgi!");
                return;
            }
            Console.WriteLine("Indeksas yra tinkamas masyvo ilgiui");
        }
    }
}
