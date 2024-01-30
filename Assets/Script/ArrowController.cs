using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 0.5f;
    //[SerializeField] private GameObject playerGo;
    //�������� �����Ǵ� �ִ� ���� �ִ°� Assign�� �� ����.
    [SerializeField] private CatEscapeGameDirector gameDirector;

    private GameObject playerGo;

    private void Start()
    {
        //�̸����� ���ӿ�����Ʈ�� ã�´�.
        this.playerGo = GameObject.Find("player");
        //Ÿ������ ������Ʈ�� ã�´�. 
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }


    void Update()
    {
        //���� * �ӵ� * �ð� �ڵ����� �������°�
        Vector3 movement = Vector3.down * 1 * Time.deltaTime;
        this.transform.Translate(movement);
      //  Debug.LogFormat("y :{0} ", this.transform.position.y);


        //���� y��ǥ��  1.38���� �۾����� �� ������ �����Ѵ�.
        if (this.transform.position.y <= -1.38f )
        {
            //Debug.LogError("����");
            //Destroy(this); //���ӿ�����Ʈ�� �ִ� arrow��Ʈ�ѷ� ������Ʈ�� ���ŵ�.
           
            Destroy(this.gameObject); //���ӿ�����Ʈ�� ������ �����Ѵ�.
        }
        //�Ÿ�
        Vector2 p1 = this.transform.position; //p1(x,y)  ȭ���� x,y�� �̾߱� 
        Vector2 p2 = this.playerGo.transform.position; //p2 �������(x,y)
        Vector2 dir = p1 - p2; //���� 
        float distane = dir.magnitude; //�Ÿ�   magnitude -> ������ ���̸� ��ȯ.ũ��(?)
        //float distance = Vector2.Distance(p1, p2);

        float r1 = this.radius; //this�� ��ũ��Ʈ�� ��� =>ȭ�� radius������ 
        PlayerControoler controller = this.playerGo.GetComponent<PlayerControoler>(); //�����(player)�� ������.
        float r2 = controller.radius;
        float sumRadius = r1 + r2;

        if(distane < sumRadius)  //�浹�� 
        {
            //Debug.LogFormat("�浹��: {0}, {1}", distane, sumRadius); 
            Destroy (this.gameObject); //������ ���� 

            this.gameDirector.DecreaseHp(); //Hp����
        }
    }


    //�̺�Ʈ �Լ�
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
