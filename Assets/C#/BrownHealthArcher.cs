using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrownHealthArcher : MonoBehaviour
{  
    private GameObject BrownHealth;
    public float health;
    public float damage;
    public GameObject Death;

    int i = 0;
    private void Update()
    {
        BrownHealth = GameObject.Find("BrownArcherHPbar");

    }   
    void OnParticleCollision(GameObject other)
    {       
        if (other.name == "Projectile 24(Clone)")
        {
            Debug.Log(other.name);          
            damage = GameObject.Find("Archer_02(Clone)").GetComponent<SsAnimator2>().damage;//找到敌人的攻击力
            health = this.GetComponent<SsAnimator>().health;
            BrownHealth.GetComponent<Slider>().value = health;
            health -= damage;
            BrownHealth.GetComponent<Slider>().value = health;
            this.GetComponent<SsAnimator>().health = health;
            if (health <= 0)
            {
                Vector3 a = this.transform.position;
                GameObject.Instantiate(Death, a, Quaternion.identity);
                Destroy(BrownHealth);
                Destroy(gameObject);
                Debug.Log("Death");
            }
        }
        else {
            if (other.name == "Projectile 12(Clone)")
            {
                Debug.Log(other.name);
                damage = GameObject.Find("Sorcerer2(Clone)").GetComponent<Fs2Animator>().damage;//找到敌人的攻击力
                health = this.GetComponent<SsAnimator>().health;
                BrownHealth.GetComponent<Slider>().value = health;
                health -= damage;
                BrownHealth.GetComponent<Slider>().value = health;
                this.GetComponent<SsAnimator>().health = health;
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
 
    private void OnCollisionEnter(Collision col)
    {
        damage= GameObject.Find("Warrior_Blue(Clone)").GetComponent<BlueWarriorAni>().damage;//找到敌人的攻击力
        GameObject obj = col.gameObject;
        Debug.Log(obj.name);
        if (obj.name == "CATRigRArmPalm1")
        {
            Vector3 a = this.transform.position;
            GameObject.Instantiate(Death, a, Quaternion.identity);
            health = this.GetComponent<SsAnimator>().health;
            BrownHealth.GetComponent<Slider>().value = health;
            Debug.Log(health);
            health -= damage;    
            BrownHealth.GetComponent<Slider>().value = health;
            this.GetComponent<SsAnimator>().health = health;
            if (health <= 0)
            {
                Destroy(BrownHealth);
                Destroy(gameObject);
                Debug.Log("Death");
            }
        }
    }
}
