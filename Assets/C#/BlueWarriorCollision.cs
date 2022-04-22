using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///碰撞检测 当被红军战士砍到掉血触发此脚本
///
public class BlueWarriorCollision : MonoBehaviour
{    
     GameObject HealthObj;   //蓝军的生命值组件
     float health; //蓝军战士的生命值
     float damage; //蓝军战士的攻击力
     float RedWarriordamage; //当前敌人的攻击力
    //public GameObject DeathEffect; //死亡血池特效

     void Start()
     {
         HealthObj = GameObject.Find("BlueWarriorHPbar");
     }

    //碰撞检测
    private void OnCollisionEnter(Collision col)
    {
        GameObject obj = col.gameObject;
        Debug.Log("--被碰撞检测物体--"+obj.name);
        if (obj.name == "RedSword")
        {
            RedWarriordamage = GameObject.Find("Warrior_Red(Clone)").GetComponent<RedWarriorAni>().damage;//找到敌人的攻击力
            //展现血条          
            //找到生命值并赋值给血条
            health = this.GetComponent<BlueWarriorAni>().health;
            HealthObj.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= RedWarriordamage;
            HealthObj.GetComponent<Slider>().value = health;
            this.GetComponent<BlueWarriorAni>().health = health;
            /*if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(DeathEffect, a, Quaternion.identity); //在红军战士死亡的地方生成血池特效
                /*Destroy(gameObject);
                Debug.Log("Death");#1#
            }*/
        }
    }      
}
