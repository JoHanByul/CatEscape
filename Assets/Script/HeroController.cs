using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    private int maxHp = 10;
   // private int hp = 0;
    public int Hp
    {
        get; set;
    }
    
    public int MaxHp
    {
        get; set;
    }
    public System.Action onhit;



    void Start()
    {
        this.Hp = this.maxHp;
        Debug.LogFormat("{0} /{1}", this.Hp, this.maxHp);
    }

   
    void Update()
    {
        //ȭ���� Ŭ���ϸ� ���ظ� �޴´�
        if(Input.GetMouseButtonDown(0))
        {
            this.Hp -= 1;
            if(this.Hp <= 0 ) this.Hp = 0;
            Debug.LogFormat("{0}/{1}",this.Hp, this.maxHp); //�������� �˷��ְ� ���� ���� 

            this.onhit(); //�븮�� �� �׷��� main���ִ� ������ ���ظ� �Ծ����ϴٰ� ���.
        }
    }
}
