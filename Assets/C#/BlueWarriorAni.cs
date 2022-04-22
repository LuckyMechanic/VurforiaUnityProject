using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

//状态
public enum WarriorState
{
    Idle,
    Run,
    Attack,
    Death
}

/// <summary>
/// 蓝军战士
/// </summary>
public class BlueWarriorAni : MonoBehaviour
{
    private int startCount = 5; //从秒开始计时  当卡牌识别到角色后开始延迟几秒开战
    public float health; 
    public int damage = 1;//攻击玩家损坏的生命值 
    //public GameObject BrownHealth2;

    public float dis1;
   // public float dis2;

    Rigidbody rg;
    private Animator anim;  //动画组件

    //状态
    public WarriorState CurrentState = WarriorState.Idle; //设定初始状态
    //动画控制器
    private Animation ani; 
    //对手
    private Transform enemy; //敌人位置

    //导航
    private NavMeshAgent agent;
    void Start()
    {
        StartCoroutine(Count());//调用这个协程
        rg = GetComponent<Rigidbody>(); //获取主角钢体组件
        ani = GetComponent<Animation>(); //获取动画
        agent = GetComponent<NavMeshAgent>(); //导航组件    
       // BrownHealth2 = GameObject.Find("BrownHealth2");
    }
    
    //战斗逻辑
    void Update()
    {
       // health = BrownHealth2.GetComponent<Slider>().value;
       // print("蓝军步兵生命值" + health);
       // GameObject[] enemyList = GameObject.FindGameObjectsWithTag("Blue");
       GameObject[] enemyList = GameObject.FindGameObjectsWithTag("Red"); //將场上红军敌人装入数组
       enemy = enemyList[0].gameObject.transform; 
        /*if (enemyList[0].gameObject.name == "Archer_02(Clone)")
        {
            enemy = GameObject.Find("Archer_02(Clone)").transform; 
        }*/
        /*else
        {
            player2 = GameObject.Find("Warrior_03(Clone)").transform;
            Debug.Log(player2);
        }*/

        if (enemy != null)
        {
            transform.LookAt(enemy);  //面向敵人
            dis1 = Vector3.Distance(enemy.position, transform.position);
        }
        //我军战败
        if (health <= 0)
        {
            CurrentState = WarriorState.Death;
        }

        //敌军战败
        float enemyhealth = enemyList[0].GetComponent<RedWarriorAni>().health;
        if (enemyhealth <= 0)
        {
            CurrentState = WarriorState.Idle;
        }

        switch (CurrentState)
        {
            case WarriorState.Idle:
                if (startCount <= 0)
                {
                    CurrentState = WarriorState.Run;
                }
                ani.Play("Idle2"); //播放站立动画
                agent.isStopped = true; //导航停止
                break;
            case WarriorState.Run:
                if (enemy != null)
                {
                    if (dis1 <= 1.6)//追踪状态
                    {
                        CurrentState = WarriorState.Attack;
                    }
                    agent.SetDestination(enemy.position);//追踪对手位置
                    ani.Play("Forward"); //播放跑步动画
                    agent.isStopped = false; //导航开始
                }
                /*else
                {                    
                    /*if (dis2 < 1.6)//追踪状态
                    {

                        CurrentState = WarriorState.Attack;
                    }#1#
                    agent.SetDestination(player2.position);//追踪对手位置
                    ani.Play("RunFront"); //播放跑步动画
                    agent.isStopped = false; //导航开始
                    Debug.Log("A" + agent);                  
                }*/
                break;
            case WarriorState.Attack:
                if (health <= 0)
                {
                    CurrentState = WarriorState.Death;
                }
                ani.Play("Attack"); //播放攻击动画
                agent.isStopped = true; //导航停止
                break;
            case WarriorState.Death:
                ani.Play("Death");
                Destroy(gameObject, 3f);
                break;
        }
    }
    //使用协程进行计时
    IEnumerator Count()
    {        
        while (startCount > 0)
        {
            yield return new WaitForSeconds(1f);
            startCount--;
        }
    }
}    