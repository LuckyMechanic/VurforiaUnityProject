using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    private GameObject Play;
    private GameObject DR;
    private GameObject SR;
    private GameObject Setting;
    private GameObject Settings;
    private float MusicControl;
    private GameObject MusicCheck;

    void Start()
    {       
        Settings = GameObject.Find("Settings");
        Settings.SetActive(false);
        DR = GameObject.Find("DR");
        DR.SetActive(false);
        SR = GameObject.Find("SR");
        SR.SetActive(false);
        Play = GameObject.Find("Play");
        Setting = GameObject.Find("Setting");
    }

    public void OnPlay(int SceneName)
    {
        SceneManager.LoadScene(SceneName);//读取场景
    }

    public void OnKS()
    {
        Play.SetActive(false);
        Setting.SetActive(false);
        DR.SetActive(true);       
        SR.SetActive(true);
    }

    public void OnSetting()
    {        
        Play.SetActive(false);
        Setting.SetActive(false);
        Settings.SetActive(true);
    }

    public void OnSettings()
    {
        MusicControl = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>().value;
        this.GetComponent<AudioSource>().volume = MusicControl;
    }

    public void OnYes()
    {
        Settings.SetActive(false);
        Play.SetActive(true);
        Setting.SetActive(true);
    }

    public void OnMusicCheckTrue()
    {
        this.GetComponent<AudioSource>().mute = true;       
    }

    public void OnMusicCheckFalse()
    {
        this.GetComponent<AudioSource>().mute = false;
    }
}
