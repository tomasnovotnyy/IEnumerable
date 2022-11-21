using System.Collections;

namespace Cviceni2111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výpis jezer za použití cyklu foreach");
            foreach (string jezero in KrasovaJezera())
            {
                Console.WriteLine(jezero);
            }
            Console.WriteLine();
            Console.WriteLine("Výpis jezer pomocí enumerátoru (iterátoru) ");
            IEnumerator enumerator = KrasovaJezera().GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine();
            Console.WriteLine("Výpis raselinovych jezer v ČR pomocí enumerátoru (iterátoru) ");
            IEnumerator enumerator2 = RaselinovaJezera().GetEnumerator();
            while (enumerator2.MoveNext())
            {
                Console.WriteLine(enumerator2.Current);
            }

            Console.WriteLine();

            foreach (int i in IsPrime(13))
            {
                Console.Write("Prvocisla: " + i);
            }

            Console.WriteLine();

            List<int> poleCisel = new List<int>() { 3, 1, 3, 8, 4, 1, 12, 8, 2, 26, 9, 11 };
            Console.Write("Stalin Sort: ");
            foreach (int i in Stalinsort(poleCisel))
            {
                Console.Write(i);
                Console.Write(", ");
            }

            Console.WriteLine();

            foreach(int number in poleCisel.Select((x) => x % 2 == 0))
            {
                Console.WriteLine("Cisla delitelna dvema: " + number);
            }
        }

        public static IEnumerable<int> Stalinsort(List<int> poleCisel)
        {
            int predchozi = poleCisel[0];
            yield return poleCisel[0];
            for(int i = 1; i < poleCisel.Count; i++)
            {
                if(predchozi < poleCisel[i])
                {
                    predchozi = poleCisel[i];
                    yield return poleCisel[i];
                }
            }
        }

        public static IEnumerable<int> IsPrime(int number)
        {
            if (number <= 0) yield break;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                {
                    yield break;
                }
            yield return number;
        }

        /*
        static bool IsPrime(int number)
        {
            if (number <= 0) return false;
            for (int i = 2; i <= number / 2; i++)
                if (number % i == 0)
                {
                    return false;
                }
            return true;
        }
        */

        public static IEnumerable KrasovaJezera()
        {
            yield return "Horní macošské jezírko";
            yield return "Dolní macošské jezírko";
            yield return "jezírko v Hranické propasti";
            yield return "Bozkovské podzemní jezero";
            yield return "Točnické jezírko";
        }

        public static IEnumerable RaselinovaJezera()
        {
            yield return "Chalupské jezírko	";
            yield return "Velké mechové jezírko";
            yield return "Jezírko pod Táborem";
            yield return "Malé mechové jezírko";
        }
    }
}