using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    [SerializeField] private float movespeed = 1.0f;


    void Update()
    {
        this.transform.Translate(Vector3.down * movespeed * Time.deltaTime);

        //y���� ���� 0�� ���ų� ������� (�ٴڿ� ������)
        if (this.transform.position.y <= 0)
        {
            Destroy(this.gameObject);   //������ ���� 
        }
    }

    
}
