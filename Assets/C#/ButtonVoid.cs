using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//unity加载场景的命名空间
using UnityEngine.UI;

public class ButtonVoid : MonoBehaviour
{
    private void Update()
    {
        
    }
    public void OnRestart()//点击“重新开始”时执行此方法
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);          
        Debug.Log("编辑状态游戏重新开始");
    }

    public void OnMenu(int SceneName)//场景跳转
    {
        SceneManager.LoadScene(SceneName);//场景的编号
    }

    public void OnQuit()//点击“退出游戏”时执行此方法
    {
        Application.Quit();
        Debug.Log("游戏退出");
    }
    public void OnContinue()//点击“游戏继续”时执行此方法
    {
        Time.timeScale = 1;
        Debug.Log("游戏继续");
        GameObject.Find("Control").GetComponent<SingleVictory>().N.SetActive(false); 
    }
    public void OnEasy()
    {
        //GameObject.FindWithTag("SingleWarrior01HPbar").GetComponent<Slider>().value = 200;
        GameObject.Find("Warrior_04(Clone)").GetComponent<SingleWarriorAni1>().j = 3;
        Time.timeScale = 1;
       // GameObject.Find("Control").GetComponent<SingleVictory>().Select.SetActive(false);
    }
    public void OnCommon()
    {
        // GameObject.FindWithTag("SingleWarrior01HPbar").GetComponent<Slider>().value = 170;
        GameObject.Find("Warrior_04(Clone)").GetComponent<SingleWarriorAni1>().j = 2;
        Time.timeScale = 1;
      //  GameObject.Find("Control").GetComponent<SingleVictory>().Select.SetActive(false);
    }
    public void OnDifficulty()
    {
        // GameObject.FindWithTag("SingleWarrior01HPbar").GetComponent<Slider>().value = 150;
        GameObject.Find("Warrior_04(Clone)").GetComponent<SingleWarriorAni1>().j = 1;
        Time.timeScale = 1;
      //  GameObject.Find("Control").GetComponent<SingleVictory>().Select.SetActive(false);
    }

      public void OnYwarrior()
    {
        print("黄兵血量条调用");
        float health = this.GetComponent<Slider>().value;
        health=GameObject.Find("YWarriorBlood").GetComponent<Slider>().value;
    }
}
