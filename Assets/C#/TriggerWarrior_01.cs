using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerWarrior_01 : MonoBehaviour
{
    private float damage;
    private float health;
    public GameObject A;

    private Animator anim;  //动画组件
    private Animation ani;
    // public Animator currentAnimator;
    // Start is called before the first frame update   
    private void Start()
    {
        ani = GetComponent<Animation>(); //获取动画 
        A = GameObject.Find("BlueHPbar");
        A.SetActive(false);     
    }
    public void OnTriggerEnter(Collider col)
    { 
        GameObject obj = col.gameObject;
        Debug.Log(obj.name);
        damage = GameObject.Find("Warrior_01(Clone)").GetComponent<RedWarriorAni>().damage;//找到自身的攻击力

        if (col.gameObject.name == "Archer_02(Clone)")//敌人1
        {            
            A.SetActive(true);
           
            //damage = GameObject.Find("Warrior_01").GetComponent<WarriorAni>().damage;
            //if (i==1)
            //{
            //    A.GetComponent<Slider>().maxValue = GameObject.Find("Archer_01").GetComponent<ArCherAni>().health;
            //}
            health = GameObject.Find("Archer_01").GetComponent<ArCherAni>().health;            
            A.GetComponent<Slider>().value = health;        
            Debug.Log(health);
            health -= damage;
            A.GetComponent<Slider>().value = health;
            GameObject.Find("Archer_01").GetComponent<ArCherAni>().health = health;
            if (health <= 0)
            {
                A.SetActive(false);
                Debug.Log("Death");               
            }
            Debug.Log("攻击力" + damage);
        }

        if (col.gameObject.name == "Warrior_03(Clone)")//敌人2
        {
            //展现敌人血条
            A.SetActive(true);          
            //找到敌人生命值并赋值给血条
            health = GameObject.Find("Warrior_03(Clone)").GetComponent<BlueWarriorAni>().health;
            A.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= damage;
            A.GetComponent<Slider>().value = health;
            GameObject.Find("Warrior_03(Clone)").GetComponent<BlueWarriorAni>().health = health;
            if (health <= 0)
            {
                A.SetActive(false);
                Debug.Log("Death");
            }
            Debug.Log("攻击力" + damage);
        }
        //if (collider.gameObject.tag == "Archer")
        //{
        //    Debug.Log(collider.name);
        //    GameObject A = GameObject.Find("ArcherHPbar");            

        //    health = A.GetComponent<Slider>().value--;
        //    Debug.Log(health); 
        //    if (health <= 0)
        //    {
        //        A.SetActive(false);
        //        Debug.Log("Death");              
        //    }
        //}
    }
}
