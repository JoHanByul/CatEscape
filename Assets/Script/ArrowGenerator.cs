using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrowGenerator : MonoBehaviour
{
    //�������� ������ ������ �������ν��Ͻ��� �����.
    [SerializeField] private GameObject arrowPrefab;
    private float delta; // ����� �ð� ����
    void Start()
    {
      //GameObject go = Instantiate(this.arrowPrefab); //������ �ν��Ͻ�

      //  //��ġ�� ����? ������ ���¿� ������ ��ġ��.
      //  //�ٸ����� �ϰ� �ʹٸ� ��ġ�� �缳���ϸ� �ȴ�.
      //  Debug.LogFormat("go: {0}", go);


    }


   
    void Update()
    {
        delta += Time.deltaTime; //���� �����Ӱ� ���� ������ ���� �ð� 
        //Debug.Log(delta); 
        if(delta > 3) 
        {
            //����
            GameObject go = Object.Instantiate(this.arrowPrefab);
            //��ġ �缳��
            float randX = Random.Range(-8.45f, 9.45f); //-8.45~8.45
             
            go.transform.position = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            delta = 0; //����ð� �ʱ�ȭ

        }

    }
}
