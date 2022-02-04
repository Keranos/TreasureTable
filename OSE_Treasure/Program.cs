using System;
using System.Linq;

namespace OSE_Treasure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string table = Console.ReadLine().ToUpper();
                if (Tables.ParentTreasureTable.Keys.Contains(table))
                {
                    var output = string.Empty;
                    foreach (var v in Tables.ParentTreasureTable[table])
                        output += v.Roll();

                    Console.WriteLine(output);
                }
            }
        }
    }
}
