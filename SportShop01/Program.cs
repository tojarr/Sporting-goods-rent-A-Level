using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportShop01.Winter;

namespace SportShop01
{
    enum Menu
    {
        Add = 1,
        Info,
        Exit,
        All,
        Winter,
        Summer,
        One,
        Items,
        admin = 123
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        // Main menu
        static void MainMenu()
        {
            ShopItems shopItem = new ShopItems();
            ShopBase shopBase = new ShopBase();
            bool b = false;
            string s;
            int num;
            while (true)
            {
                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("--- MAIN MENU ---");
                sb.AppendLine();
                sb.AppendLine("1 - " + Menu.Add + " " + Menu.Items);
                sb.AppendLine("2 - " + Menu.Info);
                sb.AppendLine("3 - " + Menu.Exit);
                Console.WriteLine(sb);
                s = Console.ReadLine();
                if (int.TryParse(s, out num))
                {
                    switch (num)
                    {
                        case (int)Menu.Add:
                            shopBase.AddAllItems(shopItem);
                            break;
                        case (int)Menu.Info:
                            shopBase.InfoMenu(shopItem);
                            break;
                        case (int)Menu.Exit:
                            b = true;
                            break;
                        case (int)Menu.admin:
                            InvizibleMenu(shopItem);
                            break;
                    }
                }
                else if ( s == "admin")
                {
                    InvizibleMenu(shopItem);
                }
                if (b == true)
                    break;
            }
        }
        //Delete, Give and Take Menu
        static void InvizibleMenu(ShopItems shopItem)
        {
            bool b = false;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.Clear();
                sb.Clear();
                sb.AppendLine("--- Welcome to invizible menu ---");
                sb.AppendLine();
                sb.AppendLine("1 - Give&Take item.");
                sb.AppendLine("2 - Delete item.");
                sb.AppendLine("3 - Exit.");
                Console.WriteLine(sb);
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        shopItem.GiveItem();
                        break;
                    case "2":
                        shopItem.DelItem();
                        break;
                    case "3":
                        b = true;
                        break;
                }
                if (b)
                    break;
            }
        }
    }
}
