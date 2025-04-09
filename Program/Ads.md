## 광고 붙이기

1. Window -> General -> Services -> Advertisement Legacy -> Install -> Configure
   
2. Edit -> project Settings -> Services -> Unity Project Id 확인
    + Unity Hub에서 해당 프로젝트의 CLOUD 항목이 CONNECTED(연결됨)인지 확인
4. Edit -> project Settings -> Services -> Members -> Dashboard -> Unity Cloud 접속
5. 좌측의 단축키 + -> Unity Ads Monetization -> Get Started
6. 설정 후 Read Integration guid 가이드의 코드 복사하여 스크립트 생성 (AdsManager.cs)
    + Initializing the SDK in Unity : 초기화 시켜주는 코드
    + Implementing rewarded ads in Unity : 광고 설정 코드
7. AdsManager ( Create Empty ) 생성 후 AdsManager.cs 추가
8. AdsManager.cs 컴포넌트의 Android Game ID & IOS Game Id Test Mode에 숫자 코드 입력
    + Unity Cloud의 설정 -> game IDs에서 확인
9. 광고를 활성화할 컴포넌트 버튼 On Click()에 스크립트 함수 추가
    + 버튼의 Text(ex.EndText) 연결하고 Implementing rewarded ads in Unity의 스크립트 추가

### In Game에서 테스트할 경우 Test Mode 체크 후 실행
### 광고를 붙이고 빌드할 경우 Test Mode 체크 해제
