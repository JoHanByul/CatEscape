using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    [SerializeField] private AudioClip appleSfx;
    [SerializeField] private AudioClip bombSfx;

    private AudioSource audioSource;
   
    void Start()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        //ȭ���� ��ġ�ϸ� ��ġ�� ��ġ�� �ٽ�Ŷ�� �����δ�. 

        //ȭ���� ��ġ�ϸ�
        if (Input.GetMouseButtonDown(0))
        {
            //Ray�� �����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //�������� RaycsatHit hit����
            RaycastHit hit;

            //if���ۼ� physics.Raycast�� Ray�� �ݶ��̴��� �浹���� �� true�� ��ȯ �׷��� ������ false�� ��ȯ 
            if(Physics.Raycast(ray.origin,ray.direction, out hit, 20f))
            {
                //���̿� �ݶ��̴��� �浹�ߴٸ�
                //�ٱ��� ��ġ�� �����δ�
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(x, 0, z);
            }
            
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("��Ҵ�!=> {0}", other.gameObject.tag);     //tag�� string  


        if(other.CompareTag("Apple"))
        {
            Debug.Log("����");
            this.audioSource.PlayOneShot(this.appleSfx);
        }
       else if (other.gameObject.tag == "Bomb")
        {
            Debug.Log("����");
            this.audioSource.PlayOneShot(this.bombSfx);

        }  //if() / else if() ���2������� ��.
        Destroy(other.gameObject);
    }
}

