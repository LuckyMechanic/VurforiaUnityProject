using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eblood : MonoBehaviour
{
    public GameObject ebloodYellow; //产生特效
     GameObject[] obj;
     //int random;
    void Start()
    {
        float health = GameObject.Find("Warrior_Red(Clone)").GetComponent<RedWarriorAni>().health;
        health += 3;
        GameObject.Find("Warrior_Red(Clone)").GetComponent<RedWarriorAni>().health = health;
    }
}