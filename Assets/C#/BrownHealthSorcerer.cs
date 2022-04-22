using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrownHealthSorcerer : MonoBehaviour
{    
    public GameObject BrownHealth;
    public float health;
    public float damage ;
    public GameObject Death;

    int i = 0;
    private void Update()
    {
        BrownHealth = GameObject.Find("BrownSorcererHPbar");
    }    

    void OnParticleCollision(GameObject other)
    {        
        if (other.name == "Projectile 24(Clone)")
        {
            Debug.Log("法师被攻击2" + other.name);
            damage = GameObject.Find("Archer_02(Clone)").GetComponent<SsAnimator2>().damage;//找到敌人的攻击力
            health = this.GetComponent<FsAnimator>().health;
            BrownHealth.GetComponent<Slider>().value=health;
            health -= damage;
            BrownHealth.GetComponent<Slider>().value = health;
            this.GetComponent<FsAnimator>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                Destroy(BrownHealth);  
                Destroy(gameObject);  
                Debug.Log("Death");   
            }
        }      
        else{
            Debug.Log("法师被攻击" + other.name);
            damage = GameObject.Find("Sorcerer2(Clone)").GetComponent<Fs2Animator>().damage;//找到敌人的攻击力
            health = this.GetComponent<FsAnimator>().health;
            BrownHealth.GetComponent<Slider>().value = health;
            health -= damage;
            BrownHealth.GetComponent<Slider>().value = health;
            this.GetComponent<FsAnimator>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                Destroy(BrownHealth);
                Destroy(gameObject);
                Debug.Log("Death");
            }
        }
    }

 
    private void OnCollisionEnter(Collision col)
    {
        damage= GameObject.Find("Warrior_03(Clone)").GetComponent<BlueWarriorAni>().damage;//找到敌人的攻击力
        GameObject obj = col.gameObject;
        Debug.Log(obj.name);
        if (obj.name == "CATRigRArmPalm1")
        {        
            health = this.GetComponent<FsAnimator>().health;
            BrownHealth.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= damage;    
            BrownHealth.GetComponent<Slider>().value = health;
            this.GetComponent<FsAnimator>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                Destroy(BrownHealth);
                Destroy(gameObject);
                Debug.Log("Death");
            }
        }
    }
}
