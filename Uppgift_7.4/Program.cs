using System;
namespace Uppgift_7_4
{
    class Program 
    { 
        static void Main(string[] args)
        {
            string[] ord = { "hej", "nej", "ja" };
            Console.WriteLine(FinnsTeckentIAllaSträngar(ord,'j'));
            Console.WriteLine(FinnsTeckentIAllaSträngar(ord, 'e'));
        }
        static bool FinnsTeckentIAllaSträngar(string[] strängArr, char tecken)
        {
            foreach (string sträng in strängArr)
            {
                if (!sträng.Contains(tecken))
                {
                    return false;
                }
            }
            return true;
        }
    }
}