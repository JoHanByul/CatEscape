using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    public float speed = 1;

    float horizontal;
    float vertical;
    void Start()
    {
        
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); //A, D�� ����Ű ��, �� �� ���� -1, 0, 1�� ���� �ϳ��� �޴´�.
        vertical = Input.GetAxisRaw("Vertical"); //W, S �Ǵ� ��, �� ����Ű
        
        Vector3 dir = new Vector3(horizontal, vertical, 0);
        
        transform.Translate(dir * Time.deltaTime * speed);


    }




}
