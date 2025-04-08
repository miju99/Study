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
[화면](https://github.com/user-attachments/assets/bbefa1aa-6e5a-474c-b70e-0c1bcb7d6dba)
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
[Dolly](https://github.com/user-attachments/assets/1c2a8f99-0cab-49b4-b508-f86d1de485c3) <br>
[Custom-Logo Zoom:1, Background Zoom:1](https://github.com/user-attachments/assets/3657b734-2df7-483b-b23a-1b9cb81b3afa)
</details>

* __Show Unity Logo__ : Unity 로고 표시 여부 설정 (무료 버전은 불가능)
* __Draw Mode__ : 로고를 어떻게 보여줄 지 설정. Unity Logo Below & All Sequential 선택
    * 각 로고마다 Logo Duration (2-10) 조절 가능
    * 2개의 로고를 각 2초로 설정하면 총 4초 + 0.5초(Fade Out)이 소요된다.
<details>
  <summary>사진</summary>
  [Unity Logo Below](https://github.com/user-attachments/assets/015ed91b-6f53-4610-b215-ed7f57465095) <br>
  [All Sequential](https://github.com/user-attachments/assets/cd55d7fe-b367-4593-8493-b8bcd9e39323)
  </details>

### Background 기능
* __Overlay Opacity__ : 배경의 투명도 (0.5-1) 조절 가능
* __Background Color__ : 백그라운드 컬러 변경. 백그라운드 이미지 설정이 None인 경우 설정 가능.
* __Blur Background Image__ : 배경에 블러효과를 줄 수 있음.
* __Background Image__ : 이미지 설정 시 배경 이미지 출력
<details>
  <summary>사진</summary>
[Background Image](https://github.com/user-attachments/assets/99ca5fd6-637c-4c44-ac72-bce321b38435)
  </details>
  
* __Alternate Portrait Image__ : 세로 화면일 때 나올 배경 이미지 설정
<details>
  <summary>사진</summary>
  [Alternate Portrait Iamge](https://github.com/user-attachments/assets/163d1589-68a2-4381-b10b-8dd249bb47fb) <br>
  * Background Image 가 있어도 현재 화면 사이즈가 세로이기 때문에 Alternate Portrait Image가 출력
    </details>

* __Static Splash Image__
  * Scaling - Center(Only Scale down) & Scale to fit(letter-boxed) & Scale to fill(cropped) 선택
      * Center (only Scale down) : 원래 크기대로 이미지 사용. 너무 큰 경우 화면에 맞게 이미지 축소
      * Scale to fit (letter-boxed) : 이미지의 가로 또는 세로 중 비율상 더 긴 쪽을 화면 크기에 맞춰 사용. 짧은 쪽 주변의 남는 공간은 검은색으로 채워진다.
      * Scale to fill (cropped) : 이미지의 가로 또는 세로 중 비율 상 더 짧은 쪽을 화면 크기에 맞춰 사용. 화면에 맞지 않은 긴 쪽은 잘린다.

### 추가
* Splash로 사용할 이미지의 Inspector창에서 Mesh Type을 변경해주어야 한다.
* Mesh Type -> Tight를 Full Rect로 변경 후 Apply
  * Tighr : 스프라이트의 투명 영역을 제외하고, RGBA를 기반으로 일정 영역을 렌더링 (빈 영역은 무시하고 스프라이트의 윤곽을 따라감)
  * Full Rect : 이미지의 크기와 동일한 형태로 스프라이트를 렌더링
