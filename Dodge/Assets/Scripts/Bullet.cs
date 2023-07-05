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
        rigid.velocity = transform.forward * speed;   //z방향

        Destroy(gameObject, 5f);
        
    }

    private void OnTriggerEnter(Collider other)        //트리거 켰을 때
    {
        //Debug.Log("트리거 : 내 총알이 무언가와 부딪혔다.");

        if(other.tag.Equals("Player"))  //부딪힌 태그가 플레이어 equals ==
        {
            //Debug.Log("플레이어와 부딪혔나?");
            PlayerController playerController = other.GetComponent<PlayerController>();  //플레이어 컨트롤러 가져와서

            if(playerController != null ) 
            {
                playerController.Die();  //죽어라
            }
        }
    }

    //private void OnCollisionEnter(Collision collision) //트리거 껐을 때
    //{
    //    Debug.Log("콜라이더 : 내 총알이 무언가와 부딪혔다.");
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
