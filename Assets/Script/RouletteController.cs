using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    //1. 마우스 왼쪽 클릭을 하면 2.회전한다
    [SerializeField] private float maxspeed = 2;  //speed는 앵글 5도씩 돌아가는것.
    [SerializeField] private float attenuation = 0.96f;
    private float speed = 0;

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        { 
            Debug.Log("Button Down!");
            speed = 1;

        }
            //마우스 버튼을 누를때마다 5도씩 돌아가세요
            this.transform.Rotate(0, 0, speed);

        //--speed; 겁나 빨리 돌음
       // speed*= 0.98f; 서서히 돌아가다가 돌아가는게 보이지 않음
       // Debug.Log(speed);


        //Input은 class / class는 타입 / 정적메서드는 점찍어서 타입으로 접근
        //GetMouseButtonDown(0) ->왼쪽버튼을 누르는 순간.  
    }
}
