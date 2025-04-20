using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Inventory
    {
        private int count = 0;
        public static List<string> changeName = new List<string>();
        static Store store = new Store();
        public static List<Item> InventoryItems = new List<Item>();
        public static Player player = new Player();
        //static public 
        public static string ShowItemList(bool indexTestNumber = false, int selectedIndex = -1)
            //ShowItemList = 상점에서 구매한 아이템의 목록을 보여주기 위해 만든 함수. (indexTestNumber = temp(count)의 숫자를 높여줄지 말지 정하기 위해) (selectedIndex = [E]값을 표시해 주기 위해)
         {
            InventoryItems.Clear();//while문으로 반복되기 때문에 중복을 없애주기 위해
            for (int i = 0; i < store.GetItemsCount(); i++) //i가 0부터 1씩 커지는데, 상점의 아이템 개수보다 작을 때,
            {
                if (store.ItemArray[i].IsSell == true) // 아이템이 구매 완료 표시가 되어있으면
                {
                    InventoryItems.Add(store.ItemArray[i]); //store의 ItemArray의 아이템 목록을 InventoryItems 리스트에 추가한다.
                }
            }

            string temp = ""; //count를 세어주기 위해
            StringBuilder stringBuilder = new StringBuilder(); //stringBuilder를 쓰기 위해

            for(int i = 0; i < InventoryItems.Count; i++)//foreach (Item item in InventoryItems) //i가 0부터 1씩 커지는데, InventoryItems의 크기(플레이어가 구매한 아이템의 개수)보다 작을때
            {

                Item item = InventoryItems[i]; //InventoryItems의 i번째에 있는 아이템을 Item 타입의 item에 저장
                if (indexTestNumber == true) // (indexTestNumber = temp(count)의 숫자를 높여줄지 말지 정하기 위해) true일 경우
                {
                    temp = (i+1).ToString(); //count는 1씩 증가한다.
                }
                if (selectedIndex == i) // (selectedIndex = [E]값을 표시해 주기 위해) 반복문에서 체크중인 i번째 아이템과 유저가 선택한 selectedIndex(playerInputWeaponNumber())에서 선택함)이 같은지 확인
                {
                    stringBuilder.AppendLine($"[E] {temp} - {item.Name} | {item.Type} +{item.TypePercent} | {item.Substance}\n"); //아이템 목록앞에 [E]추가 후 출력
                }
                else
                {
                    stringBuilder.AppendLine($" {temp} - {item.Name} | {item.Type} +{item.TypePercent} | {item.Substance}\n"); //아이템 목록 출력
                }
            }
            return stringBuilder.ToString(); // stringBuilder를 반환 (추후 다른 함수에서 출력)
        }

        public static void ShowInventory() //ShowInventory 함수 -> 
        {
            Console.WriteLine(Word(false, false)); // 1번 false = (장착 관리 화면에 들어가지 않았으므로) 아이템 순번 미출력 2번 false = "장착 관리" 미출력
            PlayerInputNumber(); // 
        }

        public static void PlayerInputNumber() // PlayerInputNumber 함수 -> 
        {
            string inputString = Console.ReadLine(); //원하는 행동 입력받기
            if (int.TryParse(inputString,out int input)) //원하는 행동을 정수형으로 변환
            {
                if (input == 0) //0을 입력받으면
                {
                    Console.Clear(); //모두 다 지운다! => 인벤토리 창을 나가고 게임 메인 화면으로 이동
                }
                else if (input == 1) //1을 입력받으면
                {
                    Console.Clear(); //모두 다 지우고,
                    ShowEquipment(); //장착 화면 들어가는 역할 (ShowEquipment 함수 실행)
                    playerInputWeaponNumber(); // 장비 착용을 위한 함수
                }
                else { }
            }

        }

        public static void playerInputWeaponNumber() //플레이어로부터 무기(+방어구)를 선택해서 착용하기 위한 함수
        {
            
            while (true)//무한루프
            {
                int input = int.Parse(Console.ReadLine()); //input값을 입력받아 정수형으로 변환
                if (input < 0 || input > InventoryItems.Count) //만약 플레이어가 0보다 작거나 (구매한)아이템 개수보다 큰 숫자를 입력한 경우,
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
                else if (input == 0) //0을 입력하면
                {
                    Console.Clear(); //모두 지우고
                    break; //빠져나간다. (나가기)
                }
                else //아이템 순번과 동일한 수 입력 시
                {
                    //E 추가
                    Console.Clear(); //모두 지우고

                    Console.WriteLine(ReWord());

                    int selectedIndex = input - 1; //selectedIndex에 입력받은 수보다 1작은 수를 저장
                    string changeItemName = ShowItemList(true, selectedIndex); //true : 아이템의 순번을 보여준다.
                                                                               //selectedIndex : 예를 들어 플레이어가 2 입력시 1이 들어가므로, 1번째 아이템에 [E]를 붙이고 출력

                    Console.Clear();
                    Console.WriteLine(ReWord());
                    //changeItemName = ShowItemList(false, selectedIndex);
                    Console.WriteLine(changeItemName); //ShowItemList() 출력 (플레이어가 선택한 숫자에 -1의 순번을 가진 아이템은 [E]와 함께 출력, 나머지는 그냥 출력

                    /*---------------------------------------플레이어 스테이터스에 반영하기 위한 라인---------------------------------------*/

                    // ShowItemList(함수) 안의 InventoryItem[] 중
                    if(changeItemName != null)
                    {
                        Item selectItems = InventoryItems[selectedIndex];
                        if( selectItems.Type == TypeCheck.Attack)
                        {
                            player.AttackPercent =  selectItems.TypePercent;
                        }
                        else if(selectItems.Type == TypeCheck.Defence)
                        {
                            player.ShieldPercent = selectItems.TypePercent;
                        }
                    }
                    // 플레이어가 선택한 숫자에 -1의 순번을 가진 아이템 = 즉 [E]를 가지고 있을 때,
                    //그 아이템이 가지고 있는 요소 중 (TypeCheck.Type) 공격력/방어력을 가지고 와서
                    //player.Attack 또는 player.Shiled에 계산


                    //changeName.Add(changeItemName);

                    Console.WriteLine("0. 나가기\n");
                    Console.WriteLine("원하시는 행동을 입력해주세요.");

                    /*if ()
                    {
                        //E 제거
                        selectedIndex = -1;
                        Console.Clear();
                        changeItemName = ShowItemList(false, selectedIndex);
                        Console.WriteLine(changeItemName);
                    }*/
                }
            }
        }

        public static void ShowEquipment() // 장착 화면 입장
        {
            Console.WriteLine(Word(true, true)); // 장착화면에서 1번 true = 아이템 앞의 순번 출력 2번 true= "1. 장착 관리" 미출력
        }

        public static string Word(bool showNumberInInventory, bool inequip) // 인벤토리 메인 화면 문구 출력 + 구매한 아이템 목록 출력 + (장착관리 창(?) 입장 시 문구 미출력) 관리
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

        public static string ReWord()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("인벤토리");
            sb.AppendLine("보유 중인 아이템을 관리할 수 있습니다.\n");
            sb.AppendLine("[아이템 목록]\n");
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
