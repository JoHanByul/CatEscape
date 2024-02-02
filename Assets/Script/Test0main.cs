using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test0main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //화면을 터치하면 마우스의 좌표를 출력하자
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);

          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //스크린포인트를 가지고 레이를 만든다
          //              시작위치    방향           색깔     몇초동안보여줌    
       //  Debug.DrawRay(ray.origin, ray.direction, Color.red, 10f); ;

            DrawArrow.ForDebug(ray.origin, ray.direction, 10, Color.red);

        }
    }
}
