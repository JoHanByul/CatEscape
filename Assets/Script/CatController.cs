using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float moveforce = 100f;

    [SerializeField] private float jumpforce = 680f;
    [SerializeField] private CloudgameDirector gameDirector;

    private Animator anim;

    private void Start()
    {
        //this.gameObject.this.GetComponent<Animator>();
        anim = GetComponent<Animator>();
        //�÷��̾� �̵��ӵ��� ���� �ִϸ��̼� �ӵ��� ��������
        //anim.speed = moveforce / 50;
        
        


        //this.gameDirector = GameObject.Find("GameDirector").GetComponent<ClimbCloudGameDirector>();
        //this.gameDirector = GameObject.FindAnyObjectByType<ClimbCloudGameDirector>();
    }

    void Update()
    {
        //�����̽��ٸ� ������ 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //���� 
            //���� ���Ѵ�
            this.rbody.AddForce(this.transform.up * this.jumpforce); //����̰� ���� up���� ���� �ʷϻ� ������ 
            this.rbody.AddForce(Vector3.up * this.jumpforce);
        }

        // -1, 0, 1 :���� (��. ������ �ֱ�. ������)
        int dirX = 0;

        if (Input.GetKey(KeyCode.LeftArrow)) //����Ű�� ������ �ִ� ���ȿ� 
        {
            //this.rbody.AddForce(-this.transform.right * this.force * 0.1f);
            dirX = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow)) //���������� ������
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
       // this.rbody.AddForce(this.transform.right * dirX * moveforce);
        
        this.anim.speed = (Mathf.Abs(this.rbody.velocity.x) / 2f);
        this.gameDirector.UpdatevelocityText(this.rbody.velocity);

        this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -2.46f, 2.46f), this.transform.position.y, this.transform.position.z);
    }

    //Trigger����� ��� �浹 ������ ���ִ� �̺�Ʈ �Լ� 
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        //�����浹�Ҷ� �ѹ��� ȣ��
        Debug.LogFormat("OnTriggerEnter2D: {0}", collision);
        //�����ȯ
        SceneManager.LoadScene("ClimbCloud");
        
    }

    
    //private void OnTriggerExit(Collider other)
    //{
    //    //�浹���� ����� �ѹ��� ȣ��
    //    Debug.LogFormat("OnTriggerExit2D: {0}", Collision);

    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    //�浹���� �� ���~~
    //    Debug.LogFormat("OnTriggerStay2D: {0}", Collision);

    //}
}

