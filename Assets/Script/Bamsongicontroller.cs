using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    private Rigidbody rbody;
    private ParticleSystem particleSystem;

    void Start()
    {
        this.rbody = this.GetComponent<Rigidbody>();
        this.particleSystem = this.GetComponent<ParticleSystem>();
        this.Shoot();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.LogFormat("OnCollisionEnter: {0}", collision.gameObject.name);
        this.rbody.isKinematic = true;

        //파티클시스템 컴포넌트 접근해서 play메서드 호출 
    }

    public void Shoot()
    {
        this.rbody.AddForce(new Vector3(0, 200, 2000));
    }

    private void Update()
    {
        //화면을 터치한 방향으로 밤송이를 날리자
        // DrawArrow.ForDebug(ray.origin, ray.direction, 10, Color.red);
        // DrawArrow.ForDebug(시작위치, 방향,)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
    }

}