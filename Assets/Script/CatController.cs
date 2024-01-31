using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float moveforce = 100f;

    [SerializeField] private float jumpforce = 680f;
    [SerializeField] private CloudgameDirector gameDirector;

    private void Start()
    {
        //this.gameDirector = GameObject.Find("GameDirector").GetComponent<ClimbCloudGameDirector>();
        //this.gameDirector = GameObject.FindAnyObjectByType<ClimbCloudGameDirector>();
    }

    void Update()
    {
        //�����̽��ٸ� ������ 
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //���� 
        //���� ���Ѵ�
        // this.rbody.AddForce(this.transform.up * this.force); //����̰� ���� up���� ���� �ʷϻ� ������ 
        //this.rbody.AddForce(Vector3.up * this.force);
        //}

        // -1, 0, 1 :���� (��. ������ �ֱ�. ������)
        int dirX = 0;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) //����Ű�� ������ �ִ� ���ȿ� 
        {
            //this.rbody.AddForce(-this.transform.right * this.force * 0.1f);
            dirX = -1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //���������� ������
        {
             //this.rbody.AddForce(this.transform.right * this.force * 0.1f);
            dirX = 1;
        }
       // Debug.Log(dirX); //����
        
        //this.transform.localScale = new Vector3(dirX, 1, 1); ������ ������ ����̰� �Ⱥ��δ�.(Ű�� ������ ������)
        //scale�� 0�̸� ����̰� ������ �ʴ°�
        //������ x�� �����ϴµ� Ű�� ������ ���� 
        //Ű�� ������ ���� = dir!= 0�� �ǹ�

        if (dirX != 0) 
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }
        



        Debug.Log(this.transform.right * dirX); //����3

        //���� ! :�ӵ��� ��������
        //velocity.x�� 3������ �Ѿ�ϱ� �������°� ���� 
        //Mathf.Abs(this.rbody.velocity.x);   
        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveforce);
        }





        //this.rbody.AddForce(���� * ��)
        this.rbody.AddForce(this.transform.right * dirX * moveforce);

        this.gameDirector.UpdatevelocityText(this.rbody.velocity);


    }


}

