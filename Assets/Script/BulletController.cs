using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private GameObject SpaceshipController;
    [SerializeField] private GameObject BulletPrefabs;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(0))
        {
            Vector3 movement = Vector3.up * 1 * Time.deltaTime;
            this.transform.Translate(movement); //if�����̷��� ���ٸ� ġ�� �ִ� �Ѱ��� ������ �ڵ����ΰ��� ���� �� ������ ����
        }
        GameObject go = Object.Instantiate(BulletPrefabs);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {

        }
    }

}

//this.distroy rbody����غ��� �׷��� ������ ��â �ߴ��� ����� ���� ���� 

//�Ѿ� ��Ʈ�ѷ������� �Ѿ��� �ڵ����� ��� �����°��� �ؾ���. 
//Ű���带 ������ �Ѿ��� �������Ѵ�. 