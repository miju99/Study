# 사운드 넣기
#### 효과음, 배경음을 넣어 게임의 재미를 더해준다.

## 효과음 Audio (오브젝트)
1. 원하는 게임 오브젝트에 AudioSource Component를 추가
2. AudioCLip에 원하는 사운드를 드래그앤 드랍으로 지정
3. Plat On Awake : 해당 오브젝트가 화면에 등장하는 순간 자동으로 사운드 재생
<details>
  <summary>사진</summary>
[Inspector](https://github.com/user-attachments/assets/1fd917e6-8b6a-4615-9d02-d53b0ceddcd6)

  </details>

## BGM Audio (오브젝트)
1. 효과음과 동일
2. Play On Awake 밑의 Loop 체크 (true)
  
## 재생/음소거/반복/자동재생/정지

       public AudioSource BGM;

       public void Start()
       {
           BGM.Play(); //재생
           BGM.mute = true; //뮤트
           BGM.loop = true; //루프
           BGM.playOnAwake = true; //자동 재생
           BGM.Stop(); //정지
       }
           
## Audio (스크립트)
#### 일정 시간이 지난 후 사운드가 나와야 할 경우 편리 (아이템 획득, 플레이어&적 행동 시 적용, 등)
1. AudioManager( Create Empty ) 오브젝트, AudioManager.cs 스크립트 생성
2. AudioSource 컴포넌트를 추가

       public AudioSource bgm; //AudioSource 타입 변수 bgm 선언
       public AudioClip clip; //AudioClip 타입 변수 clip 선언

       void Start() //게임 시작 시 한번만 실행
       {
           bgm = GetComponent<AudioSource>(); //bgm 변수의 AudioSource 컴포넌트 할당

           bgm.clip = this.clip; /audioSource가 재생할 오디오 클립 설정
           bgm.Play(); //clip 재생
       }

#### 하나의 스크립트에 일괄 작성
1. SoundManager.vs 작성

       public static SoundManager Instance;
       public AudioSource A; //AudioSource를 public으로 선언(중요)
       public AudioSource B;
       public AudioSource C;

       private void Awake()
       {
           if(Instance == null)
           {
               Instance = this;
           }
       }
2. SoundManager ( Create Empty ) 생성 후 SoundManager.cs Component 추가
3. Audio Source(Hierarchy창 우클릭 -> Audio -> Audio Source) 3개(A,B,C) 생성
4. 각각의 Audio Source에 알맞은 Audio Clip 지정 후 Play On Awake 해제
5. SoundManager의 컴포넌트에 AudioSource(A,B,C) 드래그앤 드롭으로 지정
6. 각각의 스크립트에서 원하는 시점에 효과음이 나오도록 작성

       SoundManager.instance.A.Play();
   
## Scene 이동에도 유지
1. 이동을 원하는 씬에 AudioManager( Create Empty ) 오브젝트 생성
2. AudioManager 싱글톤 패턴 적용

          public static AudioManager Instance; // 싱글톤화

          private void Awake()
          {
              if(Instance == null) //싱글톤 Instance가 설정되지 않았으면 (초기화되지 않았으면)
              {
                  Instance = this; //현재 객체(this)를 싱글톤 Instance로 설정
              }
              else
              {
                  Destroy(gameObject); //처음 만등러진 싱글톤을 제외하고 파괴
              }
              DonDestroyOnLoad(gameObject);
          }

3. 씬 이동에도 파괴되지 않도록 함

              if(Instance == null)
              {
                  Instance = this;
                  DonDestroyOnLoad(gameObject); //씬이 넘어가도 gameObject가 파괴되지 않음
              }

4. AudioManager 중복 예방

              if(Instance == null)
              {
                  Instance = this;
                  DonDestroyOnLoad(gameObject);
              }
              else
              {
                  Destroy(gameObject); //처음 만등러진 싱글톤을 제외하고 파괴
              }
