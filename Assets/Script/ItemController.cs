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

        //y축의 값이 0과 같거나 작을경우 (바닥에 닿으면)
        if (this.transform.position.y <= 0)
        {
            Destroy(this.gameObject);   //씬에서 제거 
        }
    }

    
}
