using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Inventory
    {
        static Store store = new Store();
        public static List<Item> InventoryItems = new List<Item>();
        //static public 
        public static string ShowItemList(bool indexTestNumber = false, int selectedIndex = -1) //?
         {
            InventoryItems.Clear();//중복
            for (int i = 0; i < store.GetItemsCount(); i++)
            {
                if (store.ItemArray[i].IsSell == true)
                {
                    InventoryItems.Add(store.ItemArray[i]);
                }
            }

            string temp = "";
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < InventoryItems.Count; i++)//foreach (Item item in InventoryItems)
            {
                Item item = InventoryItems[i];
                if (indexTestNumber == true)
                {
                    temp = (i+1).ToString();
                }
                if (selectedIndex == i)
                {
                    stringBuilder.AppendLine($"[E] {temp} - {item.Name} | {item.Type} +{item.TypePercent} | {item.Substance}\n");
                }
                else
                {
                    stringBuilder.AppendLine($" {temp} - {item.Name} | {item.Type} +{item.TypePercent} | {item.Substance}\n");
                }
            }
            return stringBuilder.ToString();
        }

        public static void ShowInventory()
        {
            Console.WriteLine(Word(false, false));
            PlayerInputNumber();
        }

        public static void PlayerInputNumber()
        {
            string inputString = Console.ReadLine();
            if (int.TryParse(inputString,out int input))
            {
                if (input == 0)
                {
                    Console.Clear();
                }
                else if (input == 1)
                {
                    Console.Clear();
                    ShowEquipment();
                    playerInputWeaponNumber();
                }
                else { }
            }

        }

        public static void playerInputWeaponNumber()
        { 
            int input = int.Parse(Console.ReadLine());
            if (input <= 0 || input > InventoryItems.Count)
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

            else //해당 무기 속성일 때
            {
                //E 추가
                int selectedIndex = input - 1;
                Console.Clear();
                string changeItemName = ShowItemList(true, selectedIndex);
                Console.WriteLine(changeItemName);
                //E 제거
                /*Console.Clear();
                selectedIndex = input + 1;
                string changeItemNameReturn = ShowItemList(false, selectedIndex);
                Console.WriteLine(changeItemNameReturn);*/
            }
        }

        public static void ShowEquipment()
        {
            Console.WriteLine(Word(true, true));
        }

        public static string Word(bool showNumberInInventory, bool inequip)
        {
            StringBuilder sb = new StringBuilder();
            Console.Clear();
            sb.AppendLine("인벤토리");
            sb.AppendLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            sb.AppendLine("[아이템 목록]\n");
            sb.AppendLine(ShowItemList(showNumberInInventory));
            if (inequip == false)
            {
                sb.AppendLine("1. 장착 관리");
            }
            sb.AppendLine("0. 나가기\n");
            sb.AppendLine("원하시는 행동을 입력해주세요.");
            sb.Append(">> ");
            return sb.ToString();
        }

        /*public static void selectWeaponToEquip()
        {
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                //장착 관리
                RealPurchasedItems();
                getPurchasedItems(true);
            }
            else if (input == 0)
            {
                //나가기
            }
            else { *//*선택이 안되게.*//*}
        }

        public static void RealPurchasedItems()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("인벤토리");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]\n");
        }

        public static void ShowgetPurchasedItems() //Program.cs에서 실행할 함수
        {

            RealPurchasedItems();
            getPurchasedItems(false);
            

            Console.WriteLine("1. 장착 관리 \n0. 나가기");

            Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
            selectWeaponToEquip();

        }*/


        /*
         1. 보유중인 아이템을 전부 보여준다.
            - 스토어에서 구매한 아이템을 가져와야한다.

         2. 장착 관리
            - 아이템 목록 앞에 숫자 표시

            - 아이템 선택 시 [E]표시 추가
            - 장착중이면 [E]표시 제거
            - 없는 번호 선택 시 "잘못된 입력입니다." 출력

         3. 장착 시 플레이어 스테이터스에 반영 (+n)
            - TypeCheck.Defence;
            - TypeCheck.Attack;

         */

    }
}
