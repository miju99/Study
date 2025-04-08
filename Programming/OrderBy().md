
# OrderBy()
## 정렬연산자

주어진 조건에 따라 데이터를 오름차순으로 정렬하는 함수.

배열이나 리스트와 같은 데이터를 특정 조건에 맞게 정렬할 때 사용하기 좋다.

사용 예제)

     using System;
     using System.Linq;
          
     public class Example
     {
         public static void Main()
         {
            int[] numbers = { 5, 3, 8, 1, 4 };
            var sortedNumbers = numbers.OrderBy(n => n).ToArray();
         }
     }

or

     using System.Linq;
     
     void Start()
     {
         int[] arr = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 ,7, 7 };
         arr = arr.OrderBy(x => Random.Range(0f, 7f)).ToArray();
     }
> 설명  <br>
> arr. : 배열에서 사용할 수 있는 기능을 사용하겠다. (int[] arr과 같은 이름) <br>
> OrderBy : 정렬하겠다는 뜻. <br>
> OrderBy() : 어떻게 정렬할 건지 소괄호 안에 조건을 넣음. <br>
> x => 배열을 순서대로 다 한 번씩 순회하겠다. <br>
> 한 번씩 돌아가면서 하나하나 배열을 지정해주는데(너는 몇 번째로, 너는 몇 번째로 가) 기준값이 Random.Range에서 추출된 값 <br>
>
> 예를 들어 x가 0번째일 때, <br>
> Random.Range가 한 번 실행되며 0 ~ 7사이의 임의값이 나올텐데 <br>
> 그 값을 기준으로 작거나 큰지, 또 얼만큼 작고 큰지에 따라 우선순위가 나뉘게 됨. <br>
> 
> 우선순위에 따라 정렬을 하게 되는 것. <br>
> 
> 그 후 0번으로 가면 또 다른 값이 나오게 되며 <br>
> 앞선 값보다 크거나 작을 수 있고, 또 그 정도도 다르게 된다. <br>
>
> 그 기준을 정해주는 것이 바로 Random.Range <br>
> 
> Random.Range값과 순차대로 접근하는 값을 비교해서 우선순위를 둬서 정렬한다라고 생각하면 됨. <br>
> 그렇게 정렬 후, ToArray()를 통해 배열로 만들어 준다. 라고 한 번 더 해줘야 한다. <br>
> OrderBy를 쓰게 될 경우 자료형이 Array가 아니기 때문에 Array로 바꿔주어야 하기 때문. <br>

내림차순 : OrderByDescending()
