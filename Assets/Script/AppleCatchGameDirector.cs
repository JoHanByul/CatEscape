using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class AppleCatchGameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText; 

    void Start()
    {
        this.timerText = GameObject.Find("time"); //text�� �̸��� �����ؾ���. 
        this.pointText = GameObject.Find("point");

        Debug.LogFormat("timerText: {0}", this.timerText);
        Debug.LogFormat("pointText: {0}", this.pointText);
    }
    float point = 0;

    public void GetApple()
    {
        point += 100;
        Debug.Log("100���� ������ϴ�.");
    }
    public void GetBomb()
    {
        point -= 50;
        Debug.Log("50���� �Ҿ����ϴ�.");
    }
    private void Update()
    {
        
    }
}

