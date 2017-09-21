using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop01.Winter
{
    class Skiing: WinterItem
    {
        string length;
        string mono;

        public Skiing()
        {
            
        }
        // Virtual for All Info
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder(); 
            sb.Append("Mono/Duo - "); sb.AppendLine(mono);
            sb.Append("Length - "); sb.AppendLine(length.ToString());
            Console.Write(sb);
        }
        // Virtual method for add item
        public override void AddItem()
        {
            Console.Clear();
            Console.WriteLine("--- ADD SKIING ---\n");
            base.AddItem();
            Console.Write("Enter length:"); length = Console.ReadLine();
            Console.Write("Enter mono/duo:"); mono = Console.ReadLine();
        }
    }
}
