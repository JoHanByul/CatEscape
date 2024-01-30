using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float force = 680f;
   
   
    void Update()
    {
        //스페이스바를 누르면 
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            //점프 
            //힘을 가한다
            this.rbody.AddForce(this.transform.up * this.force); //고양이가 날라감 up으로 인해 초록색 쪽으로 
            //this.rbody.AddForce(Vector3.up * this.force);

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
             this.rbody.AddForce();
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {

            }

        }


    }
}
