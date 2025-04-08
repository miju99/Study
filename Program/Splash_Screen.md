# 스플래시 화면
#### 앱 런칭 시 브랜드 이미지를 처음으로 보여주는 화면 (앱의 신뢰성 및 회사의 브랜딩을 높이기 위해 사용)
<details>
  <summary>사진</summary>
[Unity Splash 화면](https://github.com/user-attachments/assets/03de9d39-e403-40b8-a269-f3439345c6f4)
</details>

### 위치
Edit 메뉴 -> Project Settings -> Player -> Splash Image
<details>
  <summary>사진</summary>
[화면](https://github.com/user-attachments/assets/0fe02520-fac4-4d20-bc37-35f149ee2b80)
</details>

### 기본 기능
* __Show Splash Screen__ : Splash 기능 On/Off
* __Preview__ : Game View에서 Splash가 어떻게 보이는지 미리보기
* __Splash Style__ : Unity 로고의 배경/글자 색 설정. Light On dark & Dark on Light 선택
<details>
  <summary>사진</summary>
[Light On Dark](https://github.com/user-attachments/assets/3b6fe399-5bc7-4a2f-9692-d9653d41bacd) <br>
[Dark On Light](https://github.com/user-attachments/assets/7c4fbbd5-32b8-4a5e-a1a6-23dbd6188336)
</details>

* __Animation__ : Unity 로고의 애니메이션 효과를 설정. Static & Dolly & Custom 선택
    * Custom - Logo Zoom (0-1), Background Zoom (0-1) 조절 가능
<details>
  <summary>사진</summary>
[Dolly](https://github.com/user-attachments/assets/204f4c24-5e73-40da-b2f8-1c527b902f7f) <br>
[Custom-Logo Zoom:1, Background Zoom:1](https://github.com/user-attachments/assets/7209d55c-406f-42e1-8f69-5523ff6db382)
</details>

* __Show Unity Logo__ : Unity 로고 표시 여부 설정 (무료 버전은 불가능)
* __Draw Mode__ : 로고를 어떻게 보여줄 지 설정. Unity Logo Below & All Sequential 선택
  


원하는 이미지 속성
Mesh Type -> Full Rect를 Full Rect로 변경 후 Apply

Splash Image 창에서 Draw Mode -> Unity Logo Below에서 All Sequential로 변경 (유니티 로고가 뜬 후 세팅한 이미지가 뜨게 됨)
+버튼 눌러서 None의 Select 버튼 클릭 -> 원하는 이미지 선택(더블클릭) -> 저장
Animation에 Dolly를 Static으로 세팅 -> 저장
