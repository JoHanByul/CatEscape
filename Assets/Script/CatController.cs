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
        //스페이스바를 누르면 
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //점프 
        //힘을 가한다
        // this.rbody.AddForce(this.transform.up * this.force); //고양이가 날라감 up으로 인해 초록색 쪽으로 
        //this.rbody.AddForce(Vector3.up * this.force);
        //}

        // -1, 0, 1 :방향 (왼. 가만히 있기. 오른쪽)
        int dirX = 0;

        if (Input.GetKeyDown(KeyCode.LeftArrow)) //왼쪽키를 누르고 있는 동안에 
        {
            //this.rbody.AddForce(-this.transform.right * this.force * 0.1f);
            dirX = -1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //오른쪽으로 움직임
        {
             //this.rbody.AddForce(this.transform.right * this.force * 0.1f);
            dirX = 1;
        }
       // Debug.Log(dirX); //방향
        
        //this.transform.localScale = new Vector3(dirX, 1, 1); 가만히 있으면 고양이가 안보인다.(키를 누르지 않으면)
        //scale이 0이면 고양이가 보이지 않는것
        //스케일 x를 변경하는데 키가 눌렸을 때만 
        //키가 눌렸을 때만 = dir!= 0을 의미

        if (dirX != 0) 
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);
        }
        



        Debug.Log(this.transform.right * dirX); //백터3

        //도전 ! :속도를 제한하자
        //velocity.x가 3정도가 넘어가니깐 빨라지는것 같음 
        //Mathf.Abs(this.rbody.velocity.x);   
        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveforce);
        }





        //this.rbody.AddForce(방향 * 힘)
        this.rbody.AddForce(this.transform.right * dirX * moveforce);

        this.gameDirector.UpdatevelocityText(this.rbody.velocity);


    }


}

