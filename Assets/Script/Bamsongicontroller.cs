using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {

        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, 2000));
        //밤송이 제너레이터에서 밤송이를 생성하는 동시에 발사방향결정함으로 주석처리
    }

}
//수업때 작성했던 코드 

//private Rigidbody rbody;
//private ParticleSystem particleSystem;
//public Vector3 direct;

//void Start()
//{
//    this.rbody = this.GetComponent<Rigidbody>();
//    this.particleSystem = this.GetComponent<ParticleSystem>();
//    this.Shoot();
//}

//void OnCollisionEnter(Collision collision)
//{
//    Debug.LogFormat("OnCollisionEnter: {0}", collision.gameObject.name);
//    this.rbody.isKinematic = true;

//    //파티클시스템 컴포넌트 접근해서 play메서드 호출 
//    this.particleSystem.Play();
//}

//public void Shoot()
//{
//    this.rbody.AddForce(new Vector3(0, 200, 2000));
//}

//private void Update()
//{
//    //화면을 터치한 방향으로 밤송이를 날리자
//    // DrawArrow.ForDebug(ray.origin, ray.direction, 10, Color.red);
//    // DrawArrow.ForDebug(시작위치, 방향,)
//    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

//}