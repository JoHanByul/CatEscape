using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControoler : MonoBehaviour
{

      public float radius = 1f;


    void Update()
    {
        //키보드 입력을 받는 코드 작성
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //눌렀을 때 true반환
        {
            Debug.Log("왼쪽으로 2유닛만큼 이동");
            //X축으로 -2만큼 이동
            transform.Translate(-2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 2유닛만큼 이동");
            //x축으로 2만큼 이동
            transform.Translate(2, 0, 0);

        }

        //키보드 좌우로 움직였을 때 고양이가 화면 밖에 나가지 못하게 하기 
        //transform.position - 오브젝트의 위치를 가지고옴 

        //Vector3 localPosition = new Vector3(Mathf.Clamp(transform.position.x, -7.91f, 7.91f), transform.position.y, transform.position.z);
        //transform.position = localPosition;  localPosition은 임의의 이름을 뜻함. 

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.91f, 7.91f), -1.2f, 0); //-1.2f는 캐릭터가 있는 위치

        //두가지의 결과는 동일


    }
    //이벤트 함수
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
