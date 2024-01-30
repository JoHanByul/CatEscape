using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControoler : MonoBehaviour
{

      public float radius = 1f;


    void Update()
    {
        //Ű���� �Է��� �޴� �ڵ� �ۼ�
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //������ �� true��ȯ
        {
            Debug.Log("�������� 2���ָ�ŭ �̵�");
            //X������ -2��ŭ �̵�
            transform.Translate(-2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("���������� 2���ָ�ŭ �̵�");
            //x������ 2��ŭ �̵�
            transform.Translate(2, 0, 0);

        }

        //Ű���� �¿�� �������� �� ����̰� ȭ�� �ۿ� ������ ���ϰ� �ϱ� 
        //transform.position - ������Ʈ�� ��ġ�� ������� 

        //Vector3 localPosition = new Vector3(Mathf.Clamp(transform.position.x, -7.91f, 7.91f), transform.position.y, transform.position.z);
        //transform.position = localPosition;  localPosition�� ������ �̸��� ����. 

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.91f, 7.91f), -1.2f, 0); //-1.2f�� ĳ���Ͱ� �ִ� ��ġ

        //�ΰ����� ����� ����


    }
    //�̺�Ʈ �Լ�
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }
}
