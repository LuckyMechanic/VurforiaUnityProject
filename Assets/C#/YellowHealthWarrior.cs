using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowHealthWarrior : MonoBehaviour
{  
    public GameObject YellowHealth;
    public GameObject Death;
    public float health;
    public float damage;
    public float DRdamage;


    int i = 0;
    // Start is called before the first frame update
    private void Update()
    {
        YellowHealth = GameObject.Find("YellowWarriorHPbar"); //找到国王军重步兵血条         
    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name);
        Debug.Log("棕步，黄弓碰撞");
        DRdamage = GameObject.Find("Archer_01(Clone)").GetComponent<SsAnimator>().damage;//找到敌人的攻击力
        if (other.name == "Projectile 25(Clone)")
        {         
            health = this.GetComponent<BlueWarriorAni>().health;
            YellowHealth.GetComponent<Slider>().value=health;
            health -= DRdamage;
            YellowHealth.GetComponent<Slider>().value = health;
            this.GetComponent<BlueWarriorAni>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                Destroy(YellowHealth);
                Destroy(gameObject);
                Debug.Log("Death");
            }
        }
        else
        {
            if (other.name == "Projectile 22(Clone)")
            {
                Debug.Log(other.name);
                damage = GameObject.Find("Sorcerer(Clone)").GetComponent<FsAnimator>().damage;//找到敌人的攻击力
                health = this.GetComponent<SsAnimator2>().health;
                YellowHealth.GetComponent<Slider>().value = health;
                health -= damage;
                YellowHealth.GetComponent<Slider>().value = health;
                this.GetComponent<SsAnimator2>().health = health;
                if (health <= 0)
                {
                    Vector3 a = this.transform.position;
                    GameObject.Instantiate(Death, a, Quaternion.identity);
                    //isDeath = true;
                    //anim.SetBool("Death", isDeath);
                    Destroy(gameObject, 0.9f);
                    Debug.Log("Death");
                }
            }
        }
    }
    
    private void OnCollisionEnter(Collision col)
    {
        //棕步，黄步碰撞
        DRdamage = GameObject.Find("Warrior_01(Clone)").GetComponent<RedWarriorAni>().damage;//找到敌人的攻击力
        GameObject obj = col.gameObject;
        Debug.Log(obj.name);
        if (obj.name == "CATRigRArmPalm3")
        {             
            //找到角色生命值并赋值给血条
            health = this.GetComponent<BlueWarriorAni>().health;
            YellowHealth.GetComponent<Slider>().value = health;         
            Debug.Log("黄步兵"+health);
            health -= DRdamage;
            YellowHealth.GetComponent<Slider>().value = health;           
            this.GetComponent<BlueWarriorAni>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                // Destroy(YellowHealth);
                Destroy(gameObject);
                Debug.Log("Death");
            }
        }
    }
}
