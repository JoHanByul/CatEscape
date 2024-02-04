using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//밤송이를 생성하는 제너레이터   
public class BamsongiGenerator : MonoBehaviour
{
    [SerializeField]  GameObject BamsogiPrefab;

   
   
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //화면이 클릭되었는지 확인 
        {
            //밤송이 나타나는거
            //this.transform.
            //Debug.Log(Input.mousePosition);

            //화면이 클릭되었으면 밤송이 인스턴스를 만든다. 
            GameObject bamsongi = Instantiate(BamsogiPrefab);


            //탭한 곳으로 향하는 밤송이
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //ScreenPointToRay메서드는 카메라에서 탭 좌표로 향하는 벡터에 따른 Ray(광선)클래스를 반환
            //ScreenPointToRay 메서드의 반환값으로 얻을 수 있는 Ray는 origin이 MainCamera의 좌표이며 direction이 카메라에서 탭한 좌표로 향하는 벡터



            // Debug.Log(ray);
            Vector3 WorldDir = ray.direction;
            //Shoot메서드의 매개변수에 화면 안쪽 방향으로 벡터를 지정 
            bamsongi.GetComponent<BamsongiController>().Shoot(WorldDir.normalized * 2000);

        }
        

        



    }
}
