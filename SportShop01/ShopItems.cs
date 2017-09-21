using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportShop01.Winter;
using SportShop01.Summer;

namespace SportShop01
{
    class ShopItems
    {
        ShopBase[] arrSB = new ShopBase[0];
        // Add item in array
        public void AddItemArr(ShopBase item)
        {
            ShopBase[] arrSBNew = new ShopBase[arrSB.Length + 1];
            for (int i = 0; i < arrSB.Length; i++)
            {
                arrSBNew[i] = arrSB[i];
            }
            arrSBNew[arrSBNew.Length - 1] = item;
            arrSB = arrSBNew;
        }
        // Give and Take item + menu Cive and Take
        public void GiveItem()
        {
            bool b = false;
            string s;
            int num;
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                Console.Clear();
                sb.AppendLine("--- Give&Take ITEM MENU ---");
                sb.AppendLine();
                Console.WriteLine(sb);
                sb.Clear();
                PrintInfoName();
                sb.AppendLine("q - Exit.");
                sb.AppendLine();
                sb.Append("Enter num for take/give item:"); Console.Write(sb);
                s = Console.ReadLine();
                if (s == "q")
                {
                    break;
                }
                if (int.TryParse(s, out num))
                {
                    num--;
                    while (true)
                    {
                        Console.Clear();
                        sb.Clear();
                        sb.AppendLine("--- Give&Take ITEM MENU ---");
                        sb.AppendLine();
                        sb.AppendLine(arrSB[num].GetType().Name);
                        sb.AppendLine(new string('-', 7));
                        Console.Write(sb);
                        arrSB[num].Info();
                        sb.Clear();
                        sb.AppendLine();
                        sb.AppendLine("1 - Give item.");
                        sb.AppendLine("2 - Take item.");
                        sb.AppendLine("3 - Exit.");
                        Console.WriteLine(sb);
                        s = Console.ReadLine();
                        if (s == "1")
                        {
                            arrSB[num].ChangeStatus(false);
                        }
                        else if (s == "2")
                        {
                            arrSB[num].ChangeStatus(true);
                        }
                        else if (s == "3")
                        {
                            b = true;
                        }
                        if (b)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    sb.Clear();
                    sb.AppendLine("Ivalid input.");
                    sb.Append("Press any key.");
                    Console.ReadKey();
                }
                if (b)
                {
                    break;
                }
            }
        }
        // Delete item
        public void DelItem()
        {
            bool b = false;
            string s;
            int num;
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                Console.Clear();
                sb.AppendLine("--- DELETE ITEM MENU ---");
                sb.AppendLine();
                Console.WriteLine(sb);
                sb.Clear();
                PrintInfoName();
                sb.AppendLine("q - Exit.");
                sb.AppendLine();
                sb.Append("Enter num for delete item:"); Console.Write(sb);
                s = Console.ReadLine();
                if (s == "q")
                {
                    break;
                }
                if (int.TryParse(s, out num))
                {
                    num--;
                    bool arrItem = arrSB[num].InfoStatus();
                    if (arrItem)
                    {
                        ShopBase[] arrSBNew = new ShopBase[arrSB.Length - 1];
                        for (int i = 0, k = 0; i < arrSB.Length; i++, k++)
                        {
                            if ((num) == i)
                            {
                                k--;
                                continue;
                            }
                            arrSBNew[k] = arrSB[i];
                        }
                        arrSB = arrSBNew;
                        sb.Clear();
                        sb.AppendLine();
                        sb.AppendLine("Delete complete.");
                        sb.Append("Press any key");
                        sb.AppendLine();
                        Console.WriteLine(sb);
                        Console.ReadKey();
                        b = true;
                    }
                    else
                    {
                        sb.Clear();
                        sb.AppendLine();
                        sb.AppendLine("Item in use.");
                        sb.Append("Press any key.");
                        Console.WriteLine(sb);
                        Console.ReadKey();
                    }
                }
                else
                {
                    sb.Clear();
                    sb.AppendLine("Incorrect input.");
                    sb.Append("Press any key.");
                    Console.WriteLine(sb);
                    Console.ReadKey();
                }
                if (b)
                {
                    break;
                }
            }
        }
        // Print All array
        public void PrintAllArr()
        {
            for (int i = 0; i < arrSB.Length; i++)
            {
                PrintForAll(i);
            }
        }
        // Print class info and goto method print name item
        public void PrintInfoName()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrSB.Length; i++)
            {
                sb.Clear();
                Console.Write("{0} - ", i + 1);
                arrSB[i].InfoName();
                sb.Append(". // "); sb.AppendLine(arrSB[i].GetType().Name);
                Console.Write(sb);
            }
        }
        // Print one item
        public void PrintOneItem()
        {
            int num = 0;
            PrintInfoName();
            try
            {
                Console.Write("\nEnter num:");
                num = int.Parse(Console.ReadLine());// ------------------Exception1 ShopBase
            }
            catch (FormatException)
            {
                throw new FormatException("You input not integer number.");
            }
            Console.WriteLine("\n");
            try
            {
                PrintForAll(num - 1);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // Print seasons items
        public void PrintSeasons(int a)
        {
            if (a == 1)
            {
                for (int i = 0; i < arrSB.Length; i++)
                {
                    if (arrSB[i] is WinterItem)
                    {
                        PrintForAll(i);
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrSB.Length; i++)
                {
                    if (arrSB[i] is SummerItem)
                    {
                        PrintForAll(i);
                    }
                }
            }
        }
        // Print one item for method print all
        void PrintForAll(int i)
        {
            try
            {
                Console.WriteLine(arrSB[i].GetType().Name);
                Console.WriteLine(new string('-', 7));
                arrSB[i].Info();
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("Invalid number.");
            }
        }
    }
}
