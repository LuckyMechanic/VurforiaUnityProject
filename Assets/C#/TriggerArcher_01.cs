using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerArcher_01 : MonoBehaviour
{
    private float damage;
    private float health;
    private GameObject Archer_01;
    //private GameObject Projectile25;

    //public GameObject S;
    //private Animator anim;  //动画组件
    //private Animation ani;
    //// public Animator currentAnimator;
    //// Start is called before the first frame update   
    /// <summary>
    /// 
    /// </summary>

    /*private void Awake()
    {
        S = GameObject.Find("RedHPbar");
        //S.SetActive(false);
    }*/
    private void Start()
    {
        /*S = GameObject.Find("RedHPbar");
        if (S != null)
        {
            S.SetActive(false);
        }*/
        //GameObject Archer_01 = GameObject.Find("Archer_01(Clone)");
        //GameObject Projectile25 = GameObject.Find("Projectile 25(Clone)");
        //Physics.IgnoreCollision(Projectile25.GetComponent<Collider>(), Archer_01.GetComponent<Collider>());

    }

    private void Update()
    {
        /*if (S == null)
        {
            S = GameObject.Find("RedHPbar");
        }*/
    }

    public void OnTriggerEnter(Collider col2)
    {
        GameObject obj2 = col2.gameObject;
        Debug.Log(obj2.name);
        damage = GameObject.Find("Archer_01(Clone)").GetComponent<SsAnimator>().damage;//找到自身的攻击力
        Debug.Log(damage);

        if (col2.gameObject.name == "Archer_02(Clone)")//敌人1
        {
            Debug.Log("55555");
            
            //S.SetActive(true);       
            health = GameObject.Find("Archer_02(Clone)").GetComponent<SsAnimator2>().health;
            //S.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= damage;
            //S.GetComponent<Slider>().value = health;
            GameObject.Find("Archer_02(Clone)").GetComponent<SsAnimator2>().health = health;
            if (health <= 0)
            {
                //S.SetActive(false);
                Debug.Log("Death");
            }
            Debug.Log("攻击力" + damage);
            Destroy(gameObject);
        }

        if (col2.gameObject.name == "Warrior_01(Clone)")//敌人2
        {
            //展现敌人血条
            //S.SetActive(true);
            //找到敌人生命值并赋值给血条
            health = GameObject.Find("Warrior_01(Clone)").GetComponent<RedWarriorAni>().health;
            //S.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= damage;
            //S.GetComponent<Slider>().value = health;
            GameObject.Find("Warrior_01(Clone)").GetComponent<RedWarriorAni>().health = health;
            if (health <= 0)
            {
                //S.SetActive(false);
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
