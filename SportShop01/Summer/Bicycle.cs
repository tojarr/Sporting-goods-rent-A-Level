using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop01.Summer
{
    class Bicycle:SummerItem
    {
        string speednum;
        string country;

        public Bicycle()
        {

        }
        // Virtual for All Info
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Speed num - "); sb.AppendLine(speednum.ToString());
            sb.Append("Country use - "); sb.AppendLine(country.ToString());
            Console.Write(sb);
        }
        // Virtual method for add item
        public override void AddItem()
        {
            Console.Clear();
            Console.WriteLine("--- ADD BICYCLES ---\n");
            base.AddItem();
            Console.Write("Enter speed num:"); speednum = Console.ReadLine();
            Console.Write("Enter country use:"); country = Console.ReadLine();
        }
    }
}
