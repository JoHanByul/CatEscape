using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float force = 680f;
   
   
    void Update()
    {
        //�����̽��ٸ� ������ 
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            //���� 
            //���� ���Ѵ�
            this.rbody.AddForce(this.transform.up * this.force); //����̰� ���� up���� ���� �ʷϻ� ������ 
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
