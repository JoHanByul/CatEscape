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
        //����� ���ʷ����Ϳ��� ����̸� �����ϴ� ���ÿ� �߻������������� �ּ�ó��
    }

}
//������ �ۼ��ߴ� �ڵ� 

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

//    //��ƼŬ�ý��� ������Ʈ �����ؼ� play�޼��� ȣ�� 
//    this.particleSystem.Play();
//}

//public void Shoot()
//{
//    this.rbody.AddForce(new Vector3(0, 200, 2000));
//}

//private void Update()
//{
//    //ȭ���� ��ġ�� �������� ����̸� ������
//    // DrawArrow.ForDebug(ray.origin, ray.direction, 10, Color.red);
//    // DrawArrow.ForDebug(������ġ, ����,)
//    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

//}