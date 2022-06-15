using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 7f; // SerializeField = 직렬화하도록 해주는 어뷰리튜드
    // 변수나 클래스 앞에 삽입하는 대괄호는 어떤 어뷰리튜드를 다음에 나오는것에 적용한다라는 뜻
    void Start() // Start = 플레이버튼을 눌렀을때 , 지금 당장 시작
    {
        
        // transform.Rotate(0, 0, 45);  transform component로 회전값 변경 가능 Rotate( x값 , y값 , x값)
    }

   
    void Update() // Update = 프레임마다 호출 , 게임이 실행되는 매 프레임마다
    {
        // Time.deltaTime = 각 프레임이 실행되는데 시간이 얼마나 소요되었는지 알려준다. 
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount/*부동소수점이기에 f를 붙여야 Unity가 안헷갈림*/); // 컴퓨터가 초당 계산해낼 수 있는 프레임마다 45도씩 회전
        // -steerAmount = steerAmount로 사용하면 왼쪽을 누르면 오른쪽으로 가고 오른쪽은 왼쪽으로 가지만 -를 해줌으로써 방향을 제대로 맞출 수 있다.
        transform.Translate(0, moveAmount, 0); // 차량이 y축으로 0.01 만큼 프레임별로 이동
        
    }
}
