using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject appleprefab;
    public GameObject bombprefab;
    float delta = 0;
    float span = 1.0f; //1�ʿ� 1���� 
    int ratio = 3; //���� 
    
    void Start()
    {
        
    }

   
    void Update()
    {
        this.delta += Time.deltaTime;
        //�����ϰ� ������ ����� ��ź�� �����´� 
        //Random.range(��ġ)
        //���� if(����) 

        //����� ��� ��������. 
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1,11);
            if(dice <= this.ratio)
            {
                item = Instantiate(bombprefab);
            }
            else
            {
                item = Instantiate(appleprefab);
            }
        //    GameObject item = Instantiate(this.appleprefab);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 3, z);
        //}
        //if (this.delta > this.span)
        //{
        //    this.delta = 1;
        //    GameObject item = Instantiate(this.bombprefab);
        //    float x = Random.Range(-1, 2);
        //    float z = Random.Range(-1, 2);
        //    item.transform.position = new Vector3(x, 3, z);
        } //��� �ּ�ó���ϰ� ��ź�� ������ �ϸ� ��ź�� ��û ���� ��������. 

    }   
   
}
