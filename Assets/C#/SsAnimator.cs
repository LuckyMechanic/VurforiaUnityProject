using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SsAnimator : MonoBehaviour
{
    //private int startCount =1;
    private Rigidbody rig;
    private Animator anim;
    public float health =20;
    public int random01;
    public float damage =3;
    public float dis1;
    public float dis2;

    public bool isIdle = false;
    public bool isAttack = false;
    public bool isDeath = false;
    public bool isIdle2 = false;

    public GameObject[] AS;
    public Transform player1; //对手    
     
    void Start()
    {    
        rig = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        random01 = Random.Range(0, AS.Length);
    }                 
    void FixedUpdate()
    {
        AS = GameObject.FindGameObjectsWithTag("Yellow");
        if (AS.Length != 0)
        {
            player1 = AS[random01].transform; //获取对手位置
            transform.LookAt(player1);  //面向对手
            dis1 = Vector3.Distance(player1.position, transform.position);
            if (dis1 >= 1)
            {
                isAttack = true;
                anim.SetBool("AttactRange1", isAttack);
                if (health <= 0)
                {
                    isDeath = true;
                    anim.SetBool("Death", isDeath);
                    Destroy(gameObject, 0.9f);
                }
            }
        }
        else
        {
            isIdle2 = true;
            random01 = Random.Range(0, AS.Length);
            anim.SetBool("Idle2", isIdle2);            
        }
    }
}


