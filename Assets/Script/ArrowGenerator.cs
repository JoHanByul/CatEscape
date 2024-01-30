using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ArrowGenerator : MonoBehaviour
{
    //프리팹을 에셋을 가지고 프리팹인스턴스를 만든다.
    [SerializeField] private GameObject arrowPrefab;
    private float delta; // 경과된 시간 변수
    void Start()
    {
      //GameObject go = Instantiate(this.arrowPrefab); //프리팹 인스턴스

      //  //위치가 어디다? 프리팹 에셋에 설정된 위치다.
      //  //다른곳에 하고 싶다면 위치를 재설정하면 된다.
      //  Debug.LogFormat("go: {0}", go);


    }


   
    void Update()
    {
        delta += Time.deltaTime; //이전 프레임과 현재 프레임 사이 시간 
        //Debug.Log(delta); 
        if(delta > 3) 
        {
            //생성
            GameObject go = Object.Instantiate(this.arrowPrefab);
            //위치 재설정
            float randX = Random.Range(-8.45f, 9.45f); //-8.45~8.45
             
            go.transform.position = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            delta = 0; //경과시간 초기화

        }

    }
}
