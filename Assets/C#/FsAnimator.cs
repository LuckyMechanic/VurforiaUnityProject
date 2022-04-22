using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FsAnimator : MonoBehaviour
{
    //private int startCount =1;
    private Rigidbody rig;
    private Animator anim;
    public float health = 17;
    public float damage = 3;
    public int random03;
    public float dis1;
    public bool isIdle = false;
    public bool isAttack = false;
    public bool isDeath = false;
    public bool isIdle2 = false;
    public GameObject[] FS;
    private Transform player1; //对手

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        random03 = Random.Range(0, FS.Length);
    }

    void FiexdUpdate()
    {
        FS = GameObject.FindGameObjectsWithTag("Yellow");

        if (FS.Length != 0)
        {
            player1 = FS[random03].transform; //获取对手位置
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
        }else{
            isIdle2 = true;
            random03 = Random.Range(0, FS.Length);
            anim.SetBool("Idle2", isIdle2);
        }
    }
}
