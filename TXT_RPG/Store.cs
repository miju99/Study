using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    public enum TypeCheck
    {
        Attack,
        Defence
    }

    public class Item
    {
         public string Name { get; }
         public TypeCheck Type { get; }
         public int TypePercent { get; }
         public string Substance { get; }
         public string Price { get; set; }
         public bool IsSell { get; set; } //구매 유무

         public Item(string name, TypeCheck type, int typePercent, string substance, string price)
         { 
             Name = name;
             Type = type;
             TypePercent = typePercent;
             Substance = substance;
             Price = price;
             IsSell = false;
         }

    }
    public class Store
    {

        public static Item[] itemArray = new Item[6] //private
        { 
            new Item("수련자 갑옷", TypeCheck.Defence, 5, "수련에 도움을 주는 갑옷입니다.", "1000G"),
            new Item("무쇠갑옷", TypeCheck.Defence, 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", "1500G"),
            new Item("스파르타의 갑옷", TypeCheck.Defence, 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", "3500G"),
            new Item("낡은 검", TypeCheck.Attack, 2, "쉽게 볼 수 있는 낡은 검 입니다.", "600G"),
            new Item("청동 도끼", TypeCheck.Attack, 5, "어디선가 사용됐던 거 같은 도끼입니다.", "1500G"),
            new Item("스파르타의 창", TypeCheck.Attack, 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", "3000G")
        };


        public Item[] ItemArray { get { return itemArray; } }
        //public int GetCount() => return item.Length;

        public int GetItemsCount()
        {
            return itemArray.Length;
        }

        //Console.WriteLine(item);

        public void PrintItem(int x) //0 - 5번 //static이 안되는 이유 찾기
        {
            Console.WriteLine($"- {itemArray[x].Name} | {itemArray[x].Type}  +{itemArray[x].TypePercent} | {itemArray[x].Substance} | {itemArray[x].Price}");
            //return item[x];
        }
        
    }  
}    