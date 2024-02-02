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

        //��ƼŬ�ý��� ������Ʈ �����ؼ� play�޼��� ȣ�� 
    }

    public void Shoot()
    {
        this.rbody.AddForce(new Vector3(0, 200, 2000));
    }

    private void Update()
    {
        //ȭ���� ��ġ�� �������� ����̸� ������
        // DrawArrow.ForDebug(ray.origin, ray.direction, 10, Color.red);
        // DrawArrow.ForDebug(������ġ, ����,)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
    }

}