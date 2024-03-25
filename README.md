# 원격제어

- 문자열로 명령어를 전송하여 원격제어를 할 수 있다.

### 원격제어 설정

![Untitled](%E1%84%8B%E1%85%AF%E1%86%AB%E1%84%80%E1%85%A7%E1%86%A8%E1%84%8C%E1%85%A6%E1%84%8B%E1%85%A5%20aa2b24628c854a018d7a653229bf5bc0/Untitled.png)

- [Setup] - [System Configuration] - [Controller] - [Remote Control]
- Terminator는 커맨드의 끝을 무엇으로 나타낼 것인가를 말하는데, CR은 Carriage Return(\r)으로 현재 커서를 가장 앞으로 옮기는 동작이다.
- LF는 Line Feed(\n)로 커서는 그대로 두고 개행을하는 동작이다.
- Timeout을 0으로 설정하면 원격제어 클라이언트의 연결을 지속적으로 유지한다.

![Untitled](%E1%84%8B%E1%85%AF%E1%86%AB%E1%84%80%E1%85%A7%E1%86%A8%E1%84%8C%E1%85%A6%E1%84%8B%E1%85%A5%20aa2b24628c854a018d7a653229bf5bc0/Untitled%201.png)

- [Setup] - [System Configuration] - [Controller] - [Configuration]
- 위와 같이 설정 후 재연결 시 아래와 같은 화면이 나오게 된다.

![Untitled](%E1%84%8B%E1%85%AF%E1%86%AB%E1%84%80%E1%85%A7%E1%86%A8%E1%84%8C%E1%85%A6%E1%84%8B%E1%85%A5%20aa2b24628c854a018d7a653229bf5bc0/Untitled%202.png)

첫번째 라디오 버튼이 오토모드인 원격제어를 하겠다는 뜻이고, 두번째 라디오 버튼이 프로그램 수정 시 사용하는 원격제어 모드를 하겠다는 뜻이다.

# 원격제어 명령어

| 명령어 | 파라미터 | 내용*6 | 신택스 |
| --- | --- | --- | --- |
| Login | 비밀번호 | 로봇의 원격제어 기능에 로그인 한다. *4 | $Login,{비밀번호}\n |
| Logout |  | 로봇의 원격제어 기능에 로그아웃 한다. | $Logout\n |
| Start | 함수 번호 | 함수를 실행 시킨다.*1 | $Start,{함수 번호}\n |
| Stop |  | 명령을 중지 시킨다. | $Stop\n |
| Pause |  | 명령을 일시 정지한다. | $Pause\n |
| Continue |  | 명령을 재개한다. | $Continue\n |
| Reset |  | 에러와 비상정지를 리셋한다. | $Reset\n |
| SetMotorsOn | 로봇 번호 | 로봇의 모터를 켠다. 0은 모든 로봇을 말한다.*2 | $SetMotorsOn{로봇 번호}\n |
| SetMotorsOff | 로봇 번호 | 로봇의 모터를 끈다. 0은 모든 로봇을 말한다.*2 | $SetMotorsOff{로봇 번호}\n |
| GetCurRobot |  | 현재 선택된 로봇의 번호를 가져온다. | $GetCurRobot\n |
| SetCurRobot  | 로봇 번호 | 로봇을 선택한다. | $SetCurRobot\n |
| Home | 로봇 번호 | 로봇을 홈 위치로 이동시킨다. | $Home{로봇 번호}\n |
| GetIO | I/O 비트 번호 | 현재 IO 비트의 상태를 가져온다. | $GetIO,{I/O비트 번호}\n |
| SetIO | IO 비트번호, 값 | IO 비트를 설정한다. 1 켠다. 0 끈다. | $GetIO,{I/O비트 번호, 값}\n |
| GetIOByte | I/O 바이트 번호 | 현재 IO 바이트 상태를 가져온다.  | $GetIOByte,{I/O바이트 번호}\n |
| SetIOByte | I/O 바이트 번호, 값 | 현재 IO 바이트를 설정한다. 1 켠다. 0 끈다. | $SetIOByte,{I/O바이트 번호, 값}\n |
| GetIOWord | I/O 워드 번호 | 현재 IO 워드 상태를 가져온다.  | $GetIOWord{I/O 워드 번호}\n |
| SetIOWord | I/O 워드 번호, 값 | 현재 IO 워드를 설정한다. 1 켠다. 0 끈다. | $SetIOWord{I/O 워드 번호, 값}\n |
| GetMemIO | I/O 메모리 번호 | 현재 IO 메모리의 상태를 가져온다. | $GetMemIO{I/O 메모리 번호}\n |
| SetMemIO | I/O 메모리 번호, 값 | 현재 IO 메모리를 설정한다. 1 켠다. 0 끈다. | $SetMemIO{I/O 메모리 번호, 값}\n |
| GetMemIOByte | I/O 메모리 바이트 번호 | 현재 IO 메모리 바이트의 상태를 가져온다. | $GetMemIOByte{I/O 메모리 바이트 번호}\n |
| SetMemIOByte | I/O 메모리 바이트 번호, 값 | 현재 IO 메모리 바이트를 설정한다. 1 켠다. 0 끈다. | $SetMemIOByte{I/O 메모리 바이트 번호, 값}\n |
| GetMemIOWord | I/O 메모리 워드 번호 | 현재 IO 메모리 워드의 상태를 가져온다. | $GetMemIOWord{I/O 메모리 워드 번호}\n |
| SetMemIOWord | I/O 메모리 워드 번호, 값 | 현재 IO 메모리 워드를 설정한다. 1 켠다. 0 끈다. | $SetMemIOWord{I/O 메모리 워드 번호, 값}\n |
| GetVariable | 보호된 글로벌 변수,타입 | 변수의 값을 가져온다.*7 | $GetVariable{보호된 글로벌 변수, 타입}\n |
|  | 보호된 글로벌 배열 변수(인덱스),타입,가져올 배열 개수 | 배열의 변수 값을 가져올 배열 개수 만큼 가져온다.*7 | $GetVariable{보호된 글로벌 배열변수(인덱스),타입,가져올 배열 개수}\n |
| SetVariable | 보호된 글로벌 변수, 변경 값,타입 | 변수의 값을 변경 값으로 변경한다.*7 | $SetVariable{보호된 글로벌 변수, 변경 값, 타입}\n |
| GetStatus |  | 로봇의 현재 상태를 가져온다.*5 | $GetStatus\n |
| Execute | 문자열 Spel 언어 명령어 | 명령을 실행한다.*3 | $Execute{문자열 Spel 언어 명령어}\n |
| Abort |  | 명령을 중지한다. | $Abort\n |
| GetAlm |  | 현재 알람 상태를 가져온다. | $GetAlm\n |
| ResetAlm | 알람 번호 | 알람을 리셋한다. | $ResetAlm{알람 번호}\n |

### *1

| 함수 이름 | 함수 번호 |
| --- | --- |
| Main | 0 |
| Main1 | 1 |
| Main2 | 2 |
| Main3 | 3 |
| Main4 | 4 |
| Main5 | 5 |
| Main6 | 6 |
| Main7
: :
Main63 | 7
: :
63 |

### *2

![Untitled](%E1%84%8B%E1%85%AF%E1%86%AB%E1%84%80%E1%85%A7%E1%86%A8%E1%84%8C%E1%85%A6%E1%84%8B%E1%85%A5%20aa2b24628c854a018d7a653229bf5bc0/Untitled%203.png)

- 로봇의 번호는 위 이미지와 같이 확인 할 수 있다.

### *3

예시

```csharp
$Execute,"Jump P0"\n
```

### *4

비밀번호는 원격제어 설정하는 부분에서 변경 할 수 있다.

### *5

결과 예시 - aaaaaaaaaaa,bbbb

각 의미

Test/Teach/Auto/Warning/SError/Safeguard/EStop/Error/Paused/Running/Ready
ON: 1/ OFF: 0
만약 Auto와 Ready가 on일 때 결과는 “00100000001”.
bbbb는 오류가 있을 시 오류 번호를 뜻 한다.

### *6

대소문자의 구분은 하지 않아도 된다.

### *7

로봇의 프로그램에서 변수를 Global로 선언을 해야하며 옵션으로 Preserve를 주어서 사용해야한다.
Preserve는 로봇이 종료되어도 변수의 값을 기억하고 있는 옵션이며 변경해주지 않는한 그 값을 계속 기억하고 유지한다.