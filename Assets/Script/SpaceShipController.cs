using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    public float speed = 1f;

    float horizontal;
    float vertical;
    void Start()
    {
        
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //A, D나 방향키 ←, → 에 따라 -1, 0, 1의 값중 하나를 받는다.
        vertical = Input.GetAxisRaw("Vertical"); //W, S 또는 ↑, ↓ 방향키
        
        Vector3 dir = new Vector3(horizontal, vertical, 0);
        
        transform.Translate(dir * Time.deltaTime * speed);
    }
    void BulletShot()// 우주선의 위치에 따라 총알 발사하기
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // GameObject bulletGo = this.BulletGenerator.CreateBullet();

            //bulletGo.transform.position = this.firePoint.position;
        }
    }



}
