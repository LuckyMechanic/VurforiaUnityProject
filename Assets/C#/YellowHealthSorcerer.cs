using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowHealthSorcerer : MonoBehaviour
{
    //public GameObject YellowArcher;
    public GameObject YellowArcherHPbar;
    public float health;
    public float damage;
    public float health2;
    private Animator anim;
    public GameObject Death;

    public bool isIdle = false;
    public bool isAttack = false;
    public bool isDeath = false;

     void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        YellowArcherHPbar = GameObject.Find("YellowSorcererHPbar");       
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.name == "Projectile 25(Clone)")
        {
            Debug.Log(other.name);
            damage = GameObject.Find("Archer_01(Clone)").GetComponent<SsAnimator>().damage;//找到敌人的攻击力
            health = this.GetComponent<Fs2Animator>().health;
            YellowArcherHPbar.GetComponent<Slider>().value = health;
            health -= damage;
            YellowArcherHPbar.GetComponent<Slider>().value = health;
            this.GetComponent<Fs2Animator>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                isDeath = true;
                //YellowArcher.SetActive(false);
                anim.SetBool("Death", isDeath);
                Destroy(gameObject, 0.9f);
                Destroy(YellowArcherHPbar);
                Debug.Log("Death");
            }
        }
        else
        {
            if (other.name == "Projectile 22(Clone)")
            {
                Debug.Log("黄法师遭到攻击"+other.name);
                damage = GameObject.Find("Sorcerer(Clone)").GetComponent<FsAnimator>().damage;//找到敌人的攻击力
                health = this.GetComponent<Fs2Animator>().health;
                YellowArcherHPbar.GetComponent<Slider>().value = health;
                health -= damage;
                YellowArcherHPbar.GetComponent<Slider>().value = health;
                this.GetComponent<Fs2Animator>().health = health;
                if (health <= 0)
                {
                    Vector3 a = this.transform.position;
                    GameObject.Instantiate(Death, a, Quaternion.identity);
                    isDeath = true;
                    anim.SetBool("Death", isDeath);
                    Destroy(gameObject, 0.9f);
                    Destroy(YellowArcherHPbar);
                    Debug.Log("Death");
                }
            }
        }
    }

     void OnCollisionEnter(Collision col)
    {
        //黄对战棕步
        damage = GameObject.Find("Warrior_01(Clone)").GetComponent<RedWarriorAni>().damage;//找到敌人的攻击力
        GameObject obj = col.gameObject;
        Debug.Log(obj.name);
        if (obj.name == "CATRigRArmPalm3")
        {
            //展现血条
           // YellowArcherHPbar.SetActive(true);
            //找到角色生命值并赋值给血条
            health = this.GetComponent<Fs2Animator>().health;
            YellowArcherHPbar.GetComponent<Slider>().value = health;         
            health -= damage;
            YellowArcherHPbar.GetComponent<Slider>().value = health;
            this.GetComponent<Fs2Animator>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                //YellowArcher.SetActive(false);
                Destroy(YellowArcherHPbar) ;
                Destroy(gameObject);
                Debug.Log("Death");
            }
        }
    }
}
