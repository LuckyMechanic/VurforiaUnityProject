using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SsAnimator2 : MonoBehaviour
{
    private Rigidbody rig;
    private Animator anim;
    public float health = 20;
    public float damage = 2;
    public float health1;
    public int random02;

    public bool isIdle = false;
    public bool isIdle2 = false;
    public bool isAttack = false;
    public bool isDeath = false;

    public float dis1;
    public float dis2;

    private Transform player1; //对手
    private Transform player2;
    public GameObject[] BS;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        random02 = Random.Range(0, BS.Length);
    }
    // Update is called once per frame
    void Update()
    {
        BS = GameObject.FindGameObjectsWithTag("Brown");
        if (BS.Length != 0)
        {
            player1 = BS[random02].transform; //获取对手位置
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
            else
            {
                isIdle2 = true;
                random02 = Random.Range(0, BS.Length);
                anim.SetBool("Idle2", isIdle2);
            }
        }
    }
}


