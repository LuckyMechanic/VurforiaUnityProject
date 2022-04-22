using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///碰撞检测 当被蓝军战士砍到掉血触发此脚本
///
public class RedWarriorCollision : MonoBehaviour
{    
     GameObject HealthObj;   //红军的生命值组件
     float health; //当前红军战士的生命值
     float damage; //当前红军战士的攻击力
     float BlueWarriordamage; //当前敌人的攻击力
    

     void Start()
     {
         HealthObj = GameObject.Find("RedWarriorHPbar");
     }

    //碰撞检测
    private void OnCollisionEnter(Collision col)
    {
        GameObject obj = col.gameObject;
        Debug.Log("--被碰撞检测物体--"+obj.name);
        if (obj.name == "BlueSword")
        {
            BlueWarriordamage = GameObject.Find("Warrior_Blue(Clone)").GetComponent<BlueWarriorAni>().damage;//找到敌人的攻击力
            //展现血条          
            //找到红军战士生命值并赋值给血条
            health = this.GetComponent<RedWarriorAni>().health;
            HealthObj.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= BlueWarriordamage;
            HealthObj.GetComponent<Slider>().value = health;
            this.GetComponent<RedWarriorAni>().health = health;
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
