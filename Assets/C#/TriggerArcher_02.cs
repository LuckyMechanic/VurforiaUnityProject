using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerArcher_02 : MonoBehaviour
{
    private float damage;
    private float health;
    int i = 0;

    public GameObject T;
    //private Animator anim;  //动画组件
    //private Animation ani;
    //// public Animator currentAnimator;
    //// Start is called before the first frame update   
    private void Start()
    {        
        T = GameObject.Find("RedHPbar");
        T.SetActive(false);
    }
    public void OnTriggerEnter(Collider col)
    {
        if (i == 0)
        {
            T.SetActive(true);
            i++;
        }
        GameObject obj = col.gameObject;
        Debug.Log(obj.name);
        damage = GameObject.Find("Archer_02(Clone)").GetComponent<SsAnimator2>().damage;//找到自身的攻击力
        Debug.Log("攻击力" +damage);
        
        if (col.gameObject.name == "Archer_01(Clone)")//敌人1
        {
            health = GameObject.Find("Archer_01(Clone)").GetComponent<SsAnimator>().health;
            T.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= damage;
            T.GetComponent<Slider>().value = health;
            GameObject.Find("Archer_01(Clone)").GetComponent<SsAnimator>().health = health;
            if (health <= 0)
            {
                T.SetActive(false);
                Debug.Log("Death");
            }
            Destroy(gameObject);
        }

        if (col.gameObject.name == "Warrior_01(Clone)")//敌人2
        {
            //展现敌人血条
            T.SetActive(true);
            //找到敌人生命值并赋值给血条
            health = GameObject.Find("Warrior_01(Clone)").GetComponent<RedWarriorAni>().health;
            T.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= damage;
            T.GetComponent<Slider>().value = health;
            GameObject.Find("Warrior_01(Clone)").GetComponent<RedWarriorAni>().health = health;
            if (health <= 0)
            {
                T.SetActive(false);
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
