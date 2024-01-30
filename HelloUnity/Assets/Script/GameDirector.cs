using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private GameObject carGo;
    private GameObject flagGo;
    private GameObject distanceGo;

    Text distanceText;

    void Start()
    {
        this.carGo = GameObject.Find("car"); //GameObject Ŭ���� / Ŭ���� ������ �����ϴ� �޼���� �����޼���/���ӿ�����Ʈ�� �ν��Ͻ� car
        Debug.LogFormat("this.carGo: {0}", this.carGo); //car ���� ������Ʈ�� �ν��Ͻ�
        this.flagGo = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo: {0}", this.flagGo);
        this.distanceGo = GameObject.Find("distance");
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);

        distanceText = this.distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);

       


    }


    void Update()
    {
        //�� ������ ���� �ڵ����� ����� �Ÿ��� ���
        float length = this.flagGo.transform.position.x - this.carGo.transform.position.x;  //position�� Vector3 WorldPosition
        Debug.Log(length);
        distanceText.text = "�����Ÿ� : " + length.ToString("0.00") + "M";
    }
}
//1. Text.distanceText�� ���������̹Ƿ� void Start()������ �Űܾ���. / ���������� �ڱⰡ ���� �߰�ȣ�� ����� ����� ���� ����. 
//  ������ �Űܾ� �߰�ȣ�ȿ��� �Ͼ�� ������ ��� ����. 
//2. distanceText.text = "�ȳ��ϼ���"�� ���� �� �� ������ ���� ����� �ϱ����Ͽ� ������Ʈ���� �ۼ�. 
// ->float length�� ���ڷ� �ۼ��ϱ� ���ؼ� ����ȯ�� �ʿ�. =>�׷��� Tostring�� �̿�
// "������ �۾�" +(���ڿ���) length(����ȯ�� ��). Tostring() (����ȯ�� ������ �޼���) "0.00"(�Ҽ����� �ڿ� ����� �� �Ҽ����� �ڸ��°�) + M (����)
