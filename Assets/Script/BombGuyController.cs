using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BombGuyController : MonoBehaviour
{
    [SerializeField] Transform flagTransform;
    //BombGuyController가 Animator컴포넌트를 알아야한다.
    //왜? 애니메이션 전환을 해야하니까 
    //Animator 컴포넌트는 자식오브젝트 anim에 붙어있다.
    //어떻게 하면 자식오브젝트에 붙어 있는 Animator컴포넌트를 가져올 수 있을까?
    private Rigidbody2D rb;
    [SerializeField] private float moveforce = 10f;
    [SerializeField] Animator ainm;

    private void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        Move();
        InCamera();

    }





    private void InCamera()
    {
        //화면밖으로 나가지않게 하기
        float clampX = Mathf.Clamp(this.rb.transform.position.x, -2.2f, 2.2f);
        Vector3 pos = this.rb.transform.position;
        pos.x = clampX;
        this.rb.transform.position = pos;
    }

    private void Move()
    {
       //this.anim.SetInteger("State", 0);//이동중이 아니라면 Idle 애니메이션 실행

        int dirX = 0; //방향
        if (Input.GetKey(KeyCode.RightArrow)) //오른쪽 이동
        {
            dirX = 1;

        }
        if (Input.GetKey(KeyCode.LeftArrow)) //왼쪽 이동
        {
            dirX = -1;

        }
        if (dirX != 0) // 이동중이라면
        {
            this.rb.transform.localScale = new Vector3(dirX, 1, 1); // 방향에 따라 바라보는 위치 변경
         //   this.anim.SetInteger("State", 1); // Run 애니메이션 실행
        }

        this.rb.AddForce(this.transform.right * dirX * moveforce);

    }
}








//    private Coroutine coroutine;
//    private void Awake()
//    {
//        Debug.Log("Awake");
//    }

//    private void OnEnable()
//    {
//        Debug.Log("Enable");
//    }

//    private void Start()

//    {
//        Debug.Log("start");
//        //Transform animTransform = this.transform.Find("anim");
//        //GameObject animGo = animTransform.gameObject;
//        //this.ainm = animGo.GetComponent<Animator>();

//        //코루틴 함수 호출시

//        this.coroutine = this.StartCoroutine(this.CoMove(() => {
//            Debug.LogFormat("이동을 모두 완료 했습니다.");
//        }));
//        //this.coroutine = this.StartCoroutine(this.CoMove());
//        //Debug.LogFormat("coroutine: {0}", this.coroutine);
//        //this.StartCoroutine(this.CoMove());
//        //MonoBehaviour.start //MonoBehaviour = 상속받고있는 컴포넌트
//    }

//    IEnumerator CoMove(System.Action callback)
//    {
//        //매 프레임마다 앞으로 이동 
//        while (true)
//        {
//            this.transform.Translate(transform.right * 1f * Time.deltaTime);

//            float length = this.flagTransform.position.x - this.transform.position.x;
//            Debug.LogFormat("이동중.. 남은거리  : {0}", length);
//            if (length < 0.002f) //강사님은 1
//            {
//                break; //while문을 벗어난다
//            }

//            yield return null;//다음 프레임으로 넘어간다. 이거 while문 밖에 쓰지 않고 안에 쓰기 밖에 쓰면 무한루프!!!
//        }
//        Debug.Log("이동완료");
//        Debug.Log("End of CoMove");
//        callback();
//    }



//    void Update()
//    {
//        if(Input.GetMouseButtonDown(0))
//        {
//            //코루틴 멈추기
//            StopCoroutine(this.coroutine);
//        }




//    //    if (Input.GetKeyDown(KeyCode.Alpha0))  //키보드 상단 0 키보드 우측 0아님
//    //    {
//    //        Debug.Log("guy");
//    //        //애니메이션 전환하기
//    //        //전환 할때 파라미터에 값을 변경하기
//    //        this.ainm.SetInteger("State", 0);
//    //    }
//    //    if (Input.GetKeyDown(KeyCode.Alpha1))
//    //    {
//    //        Debug.Log("run");
//    //        this.ainm.SetInteger("State", 1);
//    //    }


//    //    if(Input.GetKey(KeyCode.RightArrow))
//    //    {
//    //        Debug.Log("오른쪽");
//    //        transform.Translate(1, 0, 0);

//    //    }
//    //    if (Input.GetKey(KeyCode.LeftArrow))
//    //    {
//    //        transform.Translate(-1, 0, 0);
//    //    }

//    //    if (Mathf.Abs(this.ainm.velocity.x) < 3)
//    //    {
//    //       // this.ainm.AddForce(this.transform.right * dirX * moveforce);
//    //    }

//    }




//}
