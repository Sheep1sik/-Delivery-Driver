using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
     [SerializeField] Color32 hasPackageColor = new Color32(236,146,8,255);
     [SerializeField] Color32 noPackageColor = new Color32(8,133,236,255);
     [SerializeField] float destroyDelay = 0.5f;
     bool hasPackage;
     int count = 12;
     SpriteRenderer spriteRenderer;

     
     void Start()
     {
          spriteRenderer = GetComponent<SpriteRenderer>();
          Debug.Log("물품 12개를 성공적으로 배달하세요 !");
     }

     void Update()
     {
          if (count == 0)
          {
               Debug.Log("게임 클리어 !!!");
          }
     }
     void OnCollisionEnter2D(Collision2D other) //CollisionEnter2D : 충돌을 했을때
     {
        Debug.Log("아야 !");
     }
     void OnTriggerEnter2D(Collider2D other)
     {
          // 만약에 트리거 한 것이 Package면, 콘솔에서 '물품 픽업 됨' 이라고 표시
          if(other.tag == "Package")
          {
               if(other.tag == "Package" && !hasPackage)
               {
                    Debug.Log("물품 픽업  " + "[ 배달 물품 ] : " + count);
                    hasPackage = true;
                    spriteRenderer.color = hasPackageColor;
                    Destroy(other.gameObject,destroyDelay);
                    
               }
               else
               {
                    Debug.Log("물품을 먼저 배달해주세요");
               }
          }
          if(other.tag == "Customer")
          {
               if(other.tag == "Customer" && hasPackage)
               {
                    count-=1;
                    Debug.Log("배달 완료  " + "[ 남은 물품 ] : " + count);
                    hasPackage = false;
                    spriteRenderer.color = noPackageColor;
                    Destroy(other.gameObject,destroyDelay);
               }
               else
               {
                    Debug.Log("물품이 없습니다");
               }
          }
     }
}
