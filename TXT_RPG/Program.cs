using System.Data.SqlTypes;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Text_RPG
{
    internal class Program
    {

        public static Store store = new Store();
        public static Player player = new Player();
        public static Inventory Inventory = new Inventory();

        static void Main(string[] args)
        {

            while (true)
            {
                Menu();
            }

        }//Main함수

        static void Menu()
        {
            int playerAction = -1;



            int width = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("============================================================");
            Console.WriteLine("||        스파르타 마을에 오신 여러분 환영합니다.         ||");
            //Thread.Sleep(500);
            Console.WriteLine("||  이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.  ||");
            Console.WriteLine("============================================================ \n");

            Console.ForegroundColor = ConsoleColor.White;
            string[] action = new string[3] { "1. 상태 보기", "2. 인벤토리", "3. 상점 \n" };
            for (int i = 0; i < action.Length; i++)
            {
                Console.WriteLine(action[i]);
                //Thread.Sleep(500);
            }

            while (0 > playerAction || playerAction > 4)
            {
                Console.Write("원하시는 행동을 입력해주세요. \n>> ");
                playerAction = int.Parse(Console.ReadLine());

                switch (playerAction)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("상태창으로 들어갑니다...");
                        Thread.Sleep(1000);
                        State(player);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("인벤토리로 들어갑니다...");
                        Thread.Sleep(1000);
                        OpenInventory();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("상점으로 들어갑니다...");
                        Thread.Sleep(1000);
                        StoreMenu(store, player);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("잘못된 입력입니다. \n");
                        playerAction = -1;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }//switch문


            }//while문  

            

        } //Menu함수

        static void State(Player player)
        {

            //Thread.Sleep(1000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("상태 보기");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

            //Thread.Sleep(500);
            Console.WriteLine($"Lv. {player.Level}");
            Console.WriteLine($"Chad ( {player.Job} )");
            Console.WriteLine($"공격력 : {player.Attack}");
            Console.WriteLine($"방어력 : {player.Sheild}");
            Console.WriteLine($"체력 : {player.HP}");
            Console.WriteLine($"Gold : {player.Money} G");

            Console.Write($"\n0. 나가기\n\n 원하시는 행동을 입력해주세요.\n >> ");
            string cancle = Console.ReadLine();//잘못 눌렀을 경우 다시 입력이 뜨게
            for (int i = 0; ; i++)
            {
                if (cancle == "0")
                {
                    Console.Clear();
                    return;
                }
                else { cancle = Console.ReadLine(); }
            }

        } //State함수

        static void OpenInventory()
        {
            Inventory.ShowInventory();
        }

        static void StoreMenu(Store store, Player player)
        {


            //Thread.Sleep(1000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("상점");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");

            Console.WriteLine("[보유 골드]");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(player.Money + "G");
            Console.ForegroundColor = ConsoleColor.White;

            store.PrintItem(0);
            store.PrintItem(1);
            store.PrintItem(2);
            store.PrintItem(3);
            store.PrintItem(4);
            store.PrintItem(5);


            Console.Write($"\n1. 아이템 구매\n0. 나가기\n\n 원하시는 행동을 입력해주세요.\n >> ");
            int cancle = int.Parse(Console.ReadLine());
            if (cancle == 1)
            {
                while (true) //무한 루프
                {
                    Console.Clear();
                    //아이템 앞에 숫자 생성
                    for (int i = 1; i < store.GetItemsCount(); i++)
                    {
                        Console.Write(i + " ");
                        store.PrintItem(i);
                        Console.WriteLine();
                    }
                    //구매할 아이템 선택
                    Console.WriteLine("구매할 아이템 번호를 입력해주세요. (나가기 : 0)");

                    int ItemNumber = int.Parse(Console.ReadLine()); //플레이어가 구매를 희망하는 아이템 번호(1 - 6)
                    int ItemSellNumber = ItemNumber - 1;

                    //금액 -> 구매 완료 변경
                    //플레이어가 보는 번호(1 - 6)와 실제 itemArray의 번호(0 - 5)가 다르기때문에 만듦  
                    //if (ItemNumber > 0 && ItemNumber < (store.GetItemsCount()+1)) //입력받은 값이 0보다 크고 7보다 작을 때
                    //ItemSellNumber >= 0 && ItemSellNumber <= store.GetItemsCount()
                    if (ItemNumber == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {

                        if (ItemNumber > (store.GetItemsCount() - 1) || ItemNumber < 0) //  입력받은 값이 0보다 작거나/ 5보다 클때 = 음수이거나 6 ~숫자이거나
                        {
                            Console.WriteLine($"잘못된 입력입니다. 구매 가능한 번호는 1 - {store.GetItemsCount() - 1}입니다.");
                            Thread.Sleep(1000);

                        }
                        else if (store.ItemArray[ItemNumber].IsSell == true)
                        {
                            //선택 안되게 막기
                            Console.WriteLine("이미 구매한 아이템입니다.");
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            if (player.Money >= int.Parse(store.ItemArray[ItemNumber].Price.Replace("G", "")))
                            {
                                //구매할 아이템 선택 -> ItemNumber

                                //골드 지불
                                player.Money -= int.Parse(store.ItemArray[ItemNumber].Price.Replace("G", ""));

                                //price값 변경
                                store.ItemArray[ItemNumber].Price = "구매 완료";
                                Console.WriteLine("구매를 완료했습니다.");
                                Thread.Sleep(1000);

                                //Store.Item의 {item[x].IsSell} = true로 전환
                                store.ItemArray[ItemNumber].IsSell = true;

                                //구매 지속
                                //ItemNumber = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("Gold가 부족합니다.");
                                Thread.Sleep(1000);
                            }
                        }
                    }
                }
            }
            else if (cancle == 0)
            {
                Console.Clear();
            }

        }//Store함수
    }//class
}//namespace

