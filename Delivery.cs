using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other) //CollisionEnter2D : 충돌을 했을때
   {
        Debug.Log("아야 !");
   }
    void OnTriggerEnter2D(Collider2D other)
   {
          // 만약에 트리거 한 것이 Package면, 콘솔에서 '물품 픽업 됨' 이라고 표시
          if(other.tag == "Package")
          {
               Debug.Log("물품 픽업");
          }
   }
}
