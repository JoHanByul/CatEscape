using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    //1. ���콺 ���� Ŭ���� �ϸ� 2.ȸ���Ѵ�
    [SerializeField] private float maxspeed = 2;  //speed�� �ޱ� 5���� ���ư��°�.
    [SerializeField] private float attenuation = 0.96f;
    private float speed = 0;

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        { 
            Debug.Log("Button Down!");
            speed = 1;

        }
            //���콺 ��ư�� ���������� 5���� ���ư�����
            this.transform.Rotate(0, 0, speed);

        //--speed; �̳� ���� ����
       // speed*= 0.98f; ������ ���ư��ٰ� ���ư��°� ������ ����
       // Debug.Log(speed);


        //Input�� class / class�� Ÿ�� / �����޼���� ���� Ÿ������ ����
        //GetMouseButtonDown(0) ->���ʹ�ư�� ������ ����.  
    }
}
