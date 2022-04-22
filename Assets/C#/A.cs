using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class A : MonoBehaviour
{
    //public GameObject YellowHealth2;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
      //  YellowHealth2 = GameObject.Find("YWarriorBlood"); //找到国王军重步兵血条
        
    }

    // Update is called once per frame
    void Update()
    {
        health = GameObject.Find("BlueWarriorHPbar").GetComponent<Slider>().value;
        this.GetComponent<Slider>().value = health;
    }
}
