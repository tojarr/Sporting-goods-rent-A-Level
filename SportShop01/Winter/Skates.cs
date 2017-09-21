using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop01.Winter
{
    class Skates: WinterItem
    {
        protected string size;

        public Skates()
        {
            
        }
        // Virtual for All Info
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Size - "); sb.AppendLine(size.ToString());
            Console.Write(sb);
        }
        // Virtual method for add item
        public override void AddItem()
        {
            Console.Clear();
            Console.WriteLine("--- ADD SKATES ---\n");
            base.AddItem();
            Console.Write("Enter size:"); size = Console.ReadLine();
        }
    }
}
