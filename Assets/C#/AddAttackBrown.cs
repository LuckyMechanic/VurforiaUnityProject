using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAttackBrown : MonoBehaviour
{
    public GameObject addAttackBrown;
    GameObject[] obj;
     void Start()
    {
         int damage = GameObject.Find("Warrior_Blue(Clone)").GetComponent<BlueWarriorAni>().damage;
          damage += 1;
        GameObject.Find("Warrior_Blue(Clone)").GetComponent<BlueWarriorAni>().damage = damage;
 
        /*Vector3 a = obj[random].transform.position;
        Debug.Log("随机数2 " + random);
        Debug.Log("位" + a);
        Instantiate(addAttackBrown, a, Quaternion.identity);*/
    }
}
