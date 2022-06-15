using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 카메라는 차의 위치와 같아야 한다.
    // Update is called once per frame

    // 레퍼런스란? Reference ?
    /*  스크립트가 적용된 게임 오브젝트 외에 게임 내 다른것에 접근하거나, 
        불러오거나 그것에 따라 변경해야 할 때 레퍼런스를 만들어야한다.
        유니티에게 우리가 무엇을 참조하고 있는지 알려줘야 하는것
    */

    [SerializeField] GameObject thingToFollow;
    void LateUpdate()
    {
        // transform.position = thingToFollow.transform.position; = 카메라가 차의 좌표와 같아지지만 z축도 같아져 맵이 제대로 안보인다.
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10); 
        // position에 마우스를 가져다놓으면 vector3 값임을 알 수 있고 + new Vector3 (좌표값) 을 넣어줘야 Unity에서 인식함
    }
}
