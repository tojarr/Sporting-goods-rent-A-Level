using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop01.Summer
{
    class Balls:SummerItem
    {
        string sportuse;

        public Balls()
        {

        }
        // Virtual for All Info
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Sport use - "); sb.AppendLine(sportuse.ToString());
            Console.Write(sb);
        }
        // Virtual method for add item
        public override void AddItem()
        {
            Console.Clear();
            Console.WriteLine("--- ADD BALLS ---\n");
            base.AddItem();
            Console.Write("Enter sport use:"); sportuse = Console.ReadLine();
        }
    }
}
