using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    /*private GameObject[] RedHealth;
    private GameObject[] BlueHealth;
    public GameObject BrownArcher;
    public GameObject BrownWarrior;
    public GameObject BrownEnchanter;

    public GameObject YellowWarrior;
    public GameObject YellowEnchanter;
    public GameObject YellowArcher;

     GameObject Archer01;
    public GameObject Archer02;
    public GameObject Warrior_01;
    public GameObject Warrior_02;
    public GameObject Sorcerer;
    public GameObject Sorcerer2;
  
    public GameObject blueV;
    public GameObject redV;

    public float YWhealth;
    public float YShealth;
    public float YAhealth;

    public float BWhealth;
    public float BShealth;
    public float BAhealth;

    void Start()
    {
        BrownArcher.SetActive(false);
        BrownWarrior.SetActive(false);      
        BrownEnchanter.SetActive(false);
      
        YellowWarrior.SetActive(false);        
        YellowArcher.SetActive(false);       
        YellowEnchanter.SetActive(false);

        redV.SetActive(false);
        blueV.SetActive(false);
    }   
    void Update()
    {

        Archer01 = GameObject.Find("Archer_01(Clone)");
        if(Archer01 != null)
        {
            BrownArcher.SetActive(true);            
            BAhealth = GameObject.Find("BrownArcherHPbar").GetComponent<Slider>().value;
            GameObject.Find("BrownHealth4").GetComponent<Slider>().value = BAhealth;
        }
        else
        {
            BrownArcher.SetActive(false);
        }

        Archer02 = GameObject.Find("Archer_02(Clone)");
        if(Archer02 != null)
        {
            YellowArcher.SetActive(true);            
            YAhealth = GameObject.Find("YellowArcherHPbar").GetComponent<Slider>().value;
            GameObject.Find("YArcherBlood").GetComponent<Slider>().value = YAhealth;
        }
        else
        {
            YellowArcher.SetActive(false);
        }

        Warrior_01 = GameObject.Find("Warrior_01(Clone)");
        if(Warrior_01 != null)
        {
            BrownWarrior.SetActive(true);
            BWhealth = GameObject.Find("RedWarriorHPbar").GetComponent<Slider>().value;
            GameObject.Find("BrownHealth2").GetComponent<Slider>().value = BWhealth;
        }
        else
        {
            BrownWarrior.SetActive(false);
        }

        Warrior_02 = GameObject.Find("Warrior_03(Clone)");
        if (Warrior_02 != null)
        {          
            YellowWarrior.SetActive(true);
            YWhealth = GameObject.Find("BlueWarriorHPbar").GetComponent<Slider>().value;
            GameObject.Find("YWarriorBlood").GetComponent<Slider>().value = YWhealth;
        }
        else
        {
            YellowWarrior.SetActive(false);
        }

        Sorcerer = GameObject.Find("Sorcerer(Clone)");
        if (Sorcerer != null)
        {
            BrownEnchanter.SetActive(true);
            BShealth = GameObject.Find("BrownSorcererHPbar").GetComponent<Slider>().value;
            GameObject.Find("BrownHealth3").GetComponent<Slider>().value = BShealth;
        }
        else
        {
            BrownEnchanter.SetActive(false);
        }

        Sorcerer2 = GameObject.Find("Sorcerer2(Clone)");
        if (Sorcerer2 != null)
        {            
            YellowEnchanter.SetActive(true);
            YShealth = GameObject.Find("YellowSorcererHPbar").GetComponent<Slider>().value;
            GameObject.Find("YSorcererBlood2").GetComponent<Slider>().value = YShealth;
        }
        else
        {
            YellowEnchanter.SetActive(false);
        }


        RedHealth = GameObject.FindGameObjectsWithTag("Yellow");
          BlueHealth = GameObject.FindGameObjectsWithTag("Brown");
        if (RedHealth.Length == 0&& BlueHealth.Length != 0)
        {
            blueV.SetActive(true);
        }
        else
        {
            blueV.SetActive(false);
        }
        if (BlueHealth.Length == 0&& RedHealth.Length != 0)
        {
            redV.SetActive(true);
        }
        else
        {
            redV.SetActive(false);
        }

    }*/

}
