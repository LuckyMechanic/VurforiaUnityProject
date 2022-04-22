using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoScene : MonoBehaviour
{
    public int videoLength;
    void Start()
    {
        StartCoroutine(WaitChange());
    }

    IEnumerator WaitChange()
    {
        yield return new WaitForSeconds(videoLength);
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //测试时不能执行，打包后可以执行
            SceneManager.LoadScene(1);
            print("点击鼠标左键");
        }
    }
}
