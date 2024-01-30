using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 0.5f;
    //[SerializeField] private GameObject playerGo;
    //동적으로 생성되는 애는 씬에 있는거 Assign할 수 없다.
    [SerializeField] private CatEscapeGameDirector gameDirector;

    private GameObject playerGo;

    private void Start()
    {
        //이름으로 게임오브젝트를 찾는다.
        this.playerGo = GameObject.Find("player");
        //타입으로 컴포넌트를 찾는다. 
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }


    void Update()
    {
        //방향 * 속도 * 시간 자동으로 내려가는거
        Vector3 movement = Vector3.down * 1 * Time.deltaTime;
        this.transform.Translate(movement);
      //  Debug.LogFormat("y :{0} ", this.transform.position.y);


        //현재 y좌표가  1.38보다 작아졌을 때 씬에서 제거한다.
        if (this.transform.position.y <= -1.38f )
        {
            //Debug.LogError("제거");
            //Destroy(this); //게임오브젝트에 있는 arrow컨트롤러 컴포넌트가 제거됨.
           
            Destroy(this.gameObject); //게임오브젝트를 씬에서 제거한다.
        }
        //거리
        Vector2 p1 = this.transform.position; //p1(x,y)  화살의 x,y를 이야기 
        Vector2 p2 = this.playerGo.transform.position; //p2 고양이의(x,y)
        Vector2 dir = p1 - p2; //방향 
        float distane = dir.magnitude; //거리   magnitude -> 벡터의 길이를 반환.크기(?)
        //float distance = Vector2.Distance(p1, p2);

        float r1 = this.radius; //this는 스크립트의 대상 =>화살 radius반지름 
        PlayerControoler controller = this.playerGo.GetComponent<PlayerControoler>(); //고양이(player)의 반지름.
        float r2 = controller.radius;
        float sumRadius = r1 + r2;

        if(distane < sumRadius)  //충돌함 
        {
            //Debug.LogFormat("충돌함: {0}, {1}", distane, sumRadius); 
            Destroy (this.gameObject); //씬에서 제거 

            this.gameDirector.DecreaseHp(); //Hp감소
        }
    }


    //이벤트 함수
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
