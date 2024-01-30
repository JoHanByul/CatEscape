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
        this.carGo = GameObject.Find("car"); //GameObject 클래스 / 클래스 형식의 접근하는 메서드는 정적메서드/게임오브젝트의 인스턴스 car
        Debug.LogFormat("this.carGo: {0}", this.carGo); //car 게임 오브젝트의 인스턴스
        this.flagGo = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo: {0}", this.flagGo);
        this.distanceGo = GameObject.Find("distance");
        Debug.LogFormat("this.distanceGo: {0}", this.distanceGo);

        distanceText = this.distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);

       


    }


    void Update()
    {
        //매 프레임 마다 자동차와 깃발의 거리를 계산
        float length = this.flagGo.transform.position.x - this.carGo.transform.position.x;  //position이 Vector3 WorldPosition
        Debug.Log(length);
        distanceText.text = "남은거리 : " + length.ToString("0.00") + "M";
    }
}
//1. Text.distanceText는 지역변수이므로 void Start()밖으로 옮겨야함. / 지역변수는 자기가 속한 중괄호를 벗어나면 사용을 하지 못함. 
//  밖으로 옮겨야 중괄호안에서 일어난게 위에서 출력 가능. 
//2. distanceText.text = "안녕하세요"를 했을 때 매 프레임 마다 사용을 하기위하여 업데이트문에 작성. 
// ->float length를 문자로 작성하기 위해서 형변환이 필요. =>그래서 Tostring을 이용
// "보여질 글씨" +(문자연결) length(형변환할 것). Tostring() (형변환이 가능한 메서드) "0.00"(소수점이 뒤에 길어질 때 소수점을 자르는것) + M (미터)
