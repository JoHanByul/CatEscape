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
        //화면을 클릭하면 피해를 받는다
        if(Input.GetMouseButtonDown(0))
        {
            this.Hp -= 1;
            if(this.Hp <= 0 ) this.Hp = 0;
            Debug.LogFormat("{0}/{1}",this.Hp, this.maxHp); //메인한테 알려주고 싶은 내용 

            this.onhit(); //대리자 콜 그러면 main에있는 영웅이 피해를 입었습니다가 뜬다.
        }
    }
}
