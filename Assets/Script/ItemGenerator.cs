using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject appleprefab;
    public GameObject bombprefab;
    float delta = 0;
    float span = 1.0f; //1초에 1개씩 
    int ratio = 3; //비율 
    
    void Start()
    {
        
    }

   
    void Update()
    {
        this.delta += Time.deltaTime;
        //랜덤하게 위에서 사과랑 폭탄이 내려온다 
        //Random.range(위치)
        //만약 if(조건) 

        //사과가 계속 떨어진다. 
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1,11);
            if(dice <= this.ratio)
            {
                item = Instantiate(bombprefab);
            }
            else
            {
                item = Instantiate(appleprefab);
            }
        //    GameObject item = Instantiate(this.appleprefab);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 3, z);
        //}
        //if (this.delta > this.span)
        //{
        //    this.delta = 1;
        //    GameObject item = Instantiate(this.bombprefab);
        //    float x = Random.Range(-1, 2);
        //    float z = Random.Range(-1, 2);
        //    item.transform.position = new Vector3(x, 3, z);
        } //사과 주석처리하고 폭탄만 실행을 하면 폭탄만 엄청 많이 떨어진다. 

    }   
   
}
