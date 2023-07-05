using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = default;
    private Rigidbody rigid = default;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;   //z����

        Destroy(gameObject, 5f);
        
    }

    private void OnTriggerEnter(Collider other)        //Ʈ���� ���� ��
    {
        //Debug.Log("Ʈ���� : �� �Ѿ��� ���𰡿� �ε�����.");

        if(other.tag.Equals("Player"))  //�ε��� �±װ� �÷��̾� equals ==
        {
            //Debug.Log("�÷��̾�� �ε�����?");
            PlayerController playerController = other.GetComponent<PlayerController>();  //�÷��̾� ��Ʈ�ѷ� �����ͼ�

            if(playerController != null ) 
            {
                playerController.Die();  //�׾��
            }
        }
    }

    //private void OnCollisionEnter(Collision collision) //Ʈ���� ���� ��
    //{
    //    Debug.Log("�ݶ��̴� : �� �Ѿ��� ���𰡿� �ε�����.");
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
