# 빌드하기
> 유니티를 켤 필요없이 .exe, .apk처럼 앱으로 만들어 실행되도록 하는 것.

## 방법
1. File -> Build Settings
2. Platform에서 원하는 형식 선택.
   + .exe : Windows, Mac, Linux
   + .apk : Andriod
3. Build

## 생성/실행 후 나가기
#### 생성된 앱을 실행시켜보면 나가기가 불가능해 강제종료를 해야한다.

    Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); //게임 종료
        }
    }

    ESC 버튼을 눌렀을 때 나갈 수 있다.

## Player Settings - Player
### 게임 이름 설정
1. Edit -> Project Settings -> Player
  + Company Name : 회사 이름
  + Product Name : 게임/앱 이름(영어 권장)
  + Version : 버전
    
<details>
  <summary>[사진]</summary>
   
  [Player](https://github.com/user-attachments/assets/6ce4f0bb-18a4-4275-b547-dd2828bab61c)
</details>

### 아이콘 설정
1. Edit -> Project Settings -> Player -> Default Icon

<details>
  <summary>[사진]</summary>
   
  [Player](https://github.com/user-attachments/assets/a0806797-7600-4e75-b438-26fa394dce86)
</details>
   
### 화면 해상도와 전체 화면 모드
1. Edit -> Project Settings -> Player -> Resolution and Presentation
2. ㅁ

<details>
  <summary>[사진]</summary>
   
  [Resolution and Presentation](https://github.com/user-attachments/assets/2da14814-02b6-4e45-8b58-88222f9a87f5)
</details>

### 특정 플랫폼과 관련된 나머지 설정
1. Edit -> Project Settings -> Player -> Other Settings

### 세부 설정
1. Edit -> Project Settings -> Player -> Publishing Settings
   +   빌드한 앱을 배포하기 위해 준비하는 방법에 대한 세부 설정
