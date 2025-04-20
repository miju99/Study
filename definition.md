#### Class
#### Contains
#### Coroutine
#### Dictionary
#### enum

     int enumLength = Enum.GetValues(typeof(Level)).Length;
#### Find
#### Garbage Collector
#### get
#### Interger
#### List
#### PlayerPrefs
#### private
#### public
#### return
#### RequireComponent
#### set

#### serializeField
#### Singleton
#### Static
#### StringBuilder

#### 매개변수
#### 전역변수
#### 캡슐화
#### 팩토리얼

#### 코드

 1.

     private int chain = 0;
     public void SetChain(int _chain) {chain = _chain; }
   <details>
     <summary>[추가]</summary>
     
    - 접근제한자 private인 변수의 값을 불러오고 쓸 수 있는 "프로퍼티"
    +) 필요한 기능에 따라 get, set 중 하나만 써도 됩니다.
    public int GetChain 
    { 
        get { return chain; }
        set { chain = value; }
    }

    - 접근제한자 private인 변수의 값을 "메서드"로 설정하는 방법 예시
    public void SetChain(int _chain)
    {
        chain = _chain;
    }

    - 접근제한자 private인 변수의 값을 "메서드"로 불러오는 방법 예시
    public int GetChain()
    {
        return chain;
    }
   </details>
    

 3. 

     input.GetKeyDown(KeyCode.Alpha2)

#### 추가
* System.Text.Json<->Newtonsoft.Json
* A* 알고리즘
* LIS : 최장 증가 수열
  <details>
    <summary>[설명]</summary>
     LIS(Longest Increasing Subsequence, 최장 증가 부분 수열)은 주어진 수열에서 일부 항을 제거하여 얻을 수 있는 증가하는 부분 수열 중 가장 긴 것을 의미합니다.<br>
     수열: [10, 20, 10, 30, 20, 50] <br>
     가능한 증가 수열 중 하나는 [10, 20, 30, 50]이고, 그 길이는 4입니다. 이게 이 수열의 LIS 길이입니다. 
  </details>
* 선형구조/비선형구조
* Unity DOTS(Data-Oriented Tech Stack)의 주요 개념 설명
*  L1 캐시 (Level 1 Cache)
    <details>
    <summary>[설명]</summary>
    위치: L1 캐시는 CPU 코어 내부에 위치하며, CPU와 가장 가까운 캐시입니다. <br>
    크기: L1 캐시는 매우 작습니다. 일반적으로 몇십 KB에서 수백 KB 수준입니다. <br>
    속도: 가장 빠른 캐시로, CPU가 가장 먼저 접근합니다. 캐시 히트가 발생하면 매우 짧은 시간 내에 데이터를 제공할 수 있습니다. <br>
    기능: L1 캐시는 주로 CPU 코어에서 처리할 명령어와 데이터를 저장합니다. L1 캐시는 명령어 캐시와 데이터 캐시로 나뉘어, CPU가 명령어와 데이터를 병렬로 처리할 수 있도록 도와줍니다.
    </details>
* L2 캐시 (Level 2 Cache)
    <details>
    <summary>[설명]</summary>
    위치: L2 캐시는 CPU 코어 바로 외부나 코어 내부에 위치할 수 있습니다. 코어마다 독립적인 L2 캐시를 가지고 있거나, 여러 코어가 L2 캐시를 공유하는 경우도 있습니다. <br>
    크기: L1 캐시보다 큰 수백 KB에서 몇 MB 수준입니다. <br>
    속도: L1 캐시보다는 느리지만 여전히 매우 빠릅니다. L1 캐시에서 데이터가 없을 경우, L2 캐시에서 데이터를 찾습니다. <br>
    기능: L2 캐시는 L1 캐시에서 부족한 데이터를 보충하며, CPU가 자주 사용하는 데이터나 명령어를 보관합니다.
    </details>
* L3 캐시 (Level 3 Cache)
    <details>
    <summary>[설명]</summary>
    위치: L3 캐시는 여러 CPU 코어가 공유하는 캐시입니다. CPU 다중 코어 구조에서 L3 캐시는 코어 사이에서 데이터를 공유할 수 있는 중요한 역할을 합니다. <br>
    크기: L2 캐시보다 크며, 일반적으로 몇 MB에서 수십 MB 수준입니다. <br>
    속도: L2 캐시보다 느리지만 여전히 메인 메모리(RAM)보다는 훨씬 빠릅니다. L2 캐시에서 데이터가 없을 경우 L3 캐시에서 데이터를 찾습니다. <br>
    기능: L3 캐시는 CPU 코어들이 자주 사용하는 데이터를 저장하여 캐시 미스를 줄이고 성능을 높입니다. 특히 멀티코어 환경에서 CPU 코어 간의 데이터 공유를 원활하게 합니다.
    </details>
* 순서도

#### 궁금했던 점
1. instance화를 하면 변수에 public을 안붙여도 될까?   
붙여야 다른 스크립트에서 그 스크립트의 변수를 불러올 수 있다

