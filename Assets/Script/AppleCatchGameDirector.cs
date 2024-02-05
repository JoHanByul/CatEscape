using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;


public class AppleCatchGameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText; 
    float point = 0;
    public static int applePoint = 0;
    public static int bombPoint = 0;

    void Start()
    {
        this.timerText = GameObject.Find("time"); //text�� �̸��� �����ؾ���. 
        this.pointText = GameObject.Find("point");

        Debug.LogFormat("timerText: {0}", this.timerText);
        Debug.LogFormat("pointText: {0}", this.pointText);
    }

    public void GetApple()
    {
        point += 100;
        applePoint++;
        Debug.Log("100���� ������ϴ�.");
    }
    public void GetBomb()
    {
        point -= 50;
        bombPoint++;
        Debug.Log("50���� �Ҿ����ϴ�.");
    }
    private void Update()
    {
        
    }
}

