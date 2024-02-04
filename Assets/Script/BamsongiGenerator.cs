using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����̸� �����ϴ� ���ʷ�����   
public class BamsongiGenerator : MonoBehaviour
{
    [SerializeField]  GameObject BamsogiPrefab;

   
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //ȭ���� Ŭ���Ǿ����� Ȯ�� 
        {
            //����� ��Ÿ���°�
            //this.transform.
            //Debug.Log(Input.mousePosition);

            //ȭ���� Ŭ���Ǿ����� ����� �ν��Ͻ��� �����. 
            GameObject bamsongi = Instantiate(BamsogiPrefab);


            //���� ������ ���ϴ� �����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //ScreenPointToRay�޼���� ī�޶󿡼� �� ��ǥ�� ���ϴ� ���Ϳ� ���� Ray(����)Ŭ������ ��ȯ
            //ScreenPointToRay �޼����� ��ȯ������ ���� �� �ִ� Ray�� origin�� MainCamera�� ��ǥ�̸� direction�� ī�޶󿡼� ���� ��ǥ�� ���ϴ� ����



            // Debug.Log(ray);
            Vector3 WorldDir = ray.direction;
            //Shoot�޼����� �Ű������� ȭ�� ���� �������� ���͸� ���� 
            bamsongi.GetComponent<BamsongiController>().Shoot(WorldDir.normalized * 2000);

        }
        

        



    }
}
