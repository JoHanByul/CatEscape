using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private GameObject SpaceshipController;
    [SerializeField] private GameObject BulletPrefabs;

    public class BulletGenerator : MonoBehaviour
    {
        [SerializeField] float speed = 3f;


        void Update()
        {
            this.transform.Translate(Vector2.up * this.speed * Time.deltaTime); //총알 발사

            if (this.transform.position.y > 5.15f)
            {
                Destroy(this.gameObject);
            } //화면 밖으로 나가면 총알이 사라지게
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //적이랑 충돌하면 사라짐

        if (collision.tag == "Enemy") //태그 설정 
        {
            Destroy(collision.gameObject); //적 소멸
            Destroy(this.gameObject); //총알 소멸 

        }

    }
}












//    void Update()
//    {
//        if (Input.GetKeyDown(0))
//        {
//            Vector3 movement = Vector3.up * 1 * Time.deltaTime;
//            this.transform.Translate(movement); //if없이이렇게 두줄만 치면 있는 한개만 앞으로 자동으로가고 끝남 더 나오지 않음
//        }
//        GameObject go = Object.Instantiate(BulletPrefabs);
//    }
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if(collision.tag == "Enemy")
//        {

//        }
//    }

//}

////this.distroy rbody사용해보기 그러면 프리팹 왕창 뜨던게 사라질 수도 있음 

////총알 컨트롤러에서는 총알이 자동으로 계속 나가는것을 해야함. 
////키보드를 눌러야 총알이 나가야한다. 