using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    [SerializeField] private float speed = 1f;



    void Update()
    {
        //���� * �ӵ� * �ð� 
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);


        //���� y ��ǥ�� -5���� �۾������� ������ �����Ѵ� 
        if (this.transform.position.y <= -5f)
        {

            Destroy(this.gameObject);   //���ӿ�����Ʈ�� ������ ���� 
        }

    }
}