using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportShop01.Winter;
using SportShop01.Summer;

namespace SportShop01
{
    class ShopBase
    {
        string name;
        protected int price;
        bool status;

        protected string Name { get { return name; } }

        public ShopBase()
        {
            status = true;
        }
        // Return status for delete method
        public bool InfoStatus()
        {
            return status;
        }
        // Change status for Give and Take
        public void ChangeStatus(bool b)
        {
            status = b;
        }
        // Virtual for All Info
        public virtual void Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name - "); sb.AppendLine(name);
            sb.Append("Price - "); sb.AppendLine(price.ToString());
            sb.Append("Status - ");if(status == true) { sb.AppendLine("Active"); } else { sb.AppendLine("No active"); }
            Console.Write(sb);
        }
        // Info for choice one info item
        public void InfoName()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name - "); sb.Append(name);
            Console.Write(sb);
        }
        // Virtual method for add item
        public virtual void AddItem()
        {
            Console.Write("Enter name:"); name = Console.ReadLine();
            bool b = false;
            while (true)
            {
                Console.Write("Enter price:");
                Int32 num;
                string s = Console.ReadLine();
                if (int.TryParse(s, out num))
                {
                    if( num >= 0)
                    {
                        price = num;
                        b = true;
                    }
                    else
                    {
                        IncUnput();
                    }
                    
                }
                else
                {
                    IncUnput();
                }
                if(b)
                {
                    break;
                }
            }
        }
        // Print error
        void IncUnput()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine(new string('-', 35));
            sb.Append("I Incorrect input. ");
            sb.AppendLine("Press any key. I");
            sb.AppendLine(new string('-', 35));
            Console.WriteLine(sb);
            Console.ReadKey();
        }
        // Common info menu
        public void InfoMenu(ShopItems shopItem)
        {
            bool b = false;

            while (true)
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--- INFO MENU ---");
                sb.AppendLine();
                sb.AppendLine("1 - " + Menu.All + " " + Menu.Info);
                sb.AppendLine("2 - " + Menu.Info + " " + Menu.Winter);
                sb.AppendLine("3 - " + Menu.Info + " " + Menu.Summer);
                sb.AppendLine("4 - " + Menu.One + " " + Menu.Info);
                sb.AppendLine("5 - " + Menu.Exit);
                Console.WriteLine(sb);
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.Clear();
                        shopItem.PrintAllArr();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        shopItem.PrintSeasons(1);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        shopItem.PrintSeasons(2);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        try
                        {
                            shopItem.PrintOneItem();//--------------------Exception1 ShopItem
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Error:{0}", ex.Message);
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        b = true;
                        break;
                }
                if (b == true)
                    break;
            }
        }
        // Menu choice winter or summer
        public virtual void AddAllItems(ShopItems shopItem)
        {
            bool b = false;

            while (true)
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--- SEASON MENU ---");
                sb.AppendLine();
                sb.AppendLine("1 - " + Menu.Add + " " + Menu.Winter);
                sb.AppendLine("2 - " + Menu.Add + " " + Menu.Summer);
                sb.AppendLine("3 - " + Menu.Exit);
                Console.WriteLine(sb);
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        WinterItem winItem = new WinterItem();
                        winItem.AddAllItems(shopItem);
                        break;
                    case "2":
                        SummerItem sumItem = new SummerItem();
                        sumItem.AddAllItems(shopItem);
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
