﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop01.Summer
{
    class SummerItem:ShopBase
    {
        string season;

        public SummerItem()
        {
            season = "Summer";
        }
        // Virtual for All Info
        public override void Info()
        {
            base.Info();
            StringBuilder sb = new StringBuilder();
            sb.Append("Season - "); sb.AppendLine(season);
            Console.Write(sb);
        }
        // Virtual method for add item
        public override void AddItem()
        {
            base.AddItem();
        }
        // Menu for choice add item
        public override void AddAllItems(ShopItems shopItem)
        {
            bool b = false;

            while (true)
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--- SUMMER MENU ---");
                sb.AppendLine();
                sb.AppendLine("1 - Add ball.");
                sb.AppendLine("2 - Add bicycle.");
                sb.AppendLine("3 - Exit.");
                Console.WriteLine(sb);
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        ShopBase Item1 = new Balls();
                        Item1.AddItem();
                        shopItem.AddItemArr(Item1);
                        break;
                    case "2":
                        ShopBase Item2 = new Bicycle();
                        Item2.AddItem();
                        shopItem.AddItemArr(Item2);
                        break;
                    case "3":
                        b = true;
                        break;
                }
                if (b == true)
                    break;
            }
        }
    }
}
