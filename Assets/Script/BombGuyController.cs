using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombGuyController : MonoBehaviour
{
    [SerializeField] Transform flagTransform;
    //BombGuyController�� Animator������Ʈ�� �˾ƾ��Ѵ�.
    //��? �ִϸ��̼� ��ȯ�� �ؾ��ϴϱ� 
    //Animator ������Ʈ�� �ڽĿ�����Ʈ anim�� �پ��ִ�.
    //��� �ϸ� �ڽĿ�����Ʈ�� �پ� �ִ� Animator������Ʈ�� ������ �� ������?

    [SerializeField] Animator ainm;
   
    private Coroutine coroutine;
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Enable");
    }

    private void Start()
       
    {
        Debug.Log("start");
        //Transform animTransform = this.transform.Find("anim");
        //GameObject animGo = animTransform.gameObject;
        //this.ainm = animGo.GetComponent<Animator>();

        //�ڷ�ƾ �Լ� ȣ���

        this.coroutine = this.StartCoroutine(this.CoMove(() => {
            Debug.LogFormat("�̵��� ��� �Ϸ� �߽��ϴ�.");
        }));
        //this.coroutine = this.StartCoroutine(this.CoMove());
        //Debug.LogFormat("coroutine: {0}", this.coroutine);
        //this.StartCoroutine(this.CoMove());
        //MonoBehaviour.start //MonoBehaviour = ��ӹް��ִ� ������Ʈ
    }

    IEnumerator CoMove(System.Action callback)
    {
        //�� �����Ӹ��� ������ �̵� 
        while (true)
        {
            this.transform.Translate(transform.right * 1f * Time.deltaTime);

            float length = this.flagTransform.position.x - this.transform.position.x;
            Debug.LogFormat("�̵���.. �����Ÿ�  : {0}", length);
            if (length < 0.002f) //������� 1
            {
                break; //while���� �����
            }

            yield return null;//���� ���������� �Ѿ��. �̰� while�� �ۿ� ���� �ʰ� �ȿ� ���� �ۿ� ���� ���ѷ���!!!
        }
        Debug.Log("�̵��Ϸ�");
        Debug.Log("End of CoMove");
        callback();
    }



    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //�ڷ�ƾ ���߱�
            StopCoroutine(this.coroutine);
        }




    //    if (Input.GetKeyDown(KeyCode.Alpha0))  //Ű���� ��� 0 Ű���� ���� 0�ƴ�
    //    {
    //        Debug.Log("guy");
    //        //�ִϸ��̼� ��ȯ�ϱ�
    //        //��ȯ �Ҷ� �Ķ���Ϳ� ���� �����ϱ�
    //        this.ainm.SetInteger("State", 0);
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        Debug.Log("run");
    //        this.ainm.SetInteger("State", 1);
    //    }
    

    //    if(Input.GetKey(KeyCode.RightArrow))
    //    {
    //        Debug.Log("������");
    //        transform.Translate(1, 0, 0);

    //    }
    //    if (Input.GetKey(KeyCode.LeftArrow))
    //    {
    //        transform.Translate(-1, 0, 0);
    //    }

    //    if (Mathf.Abs(this.ainm.velocity.x) < 3)
    //    {
    //       // this.ainm.AddForce(this.transform.right * dirX * moveforce);
    //    }

    }

    


}
