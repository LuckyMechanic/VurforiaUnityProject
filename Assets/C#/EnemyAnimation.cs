using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    Rigidbody rg;
    private Animation anim;  //动画组件

    void Start()
    {
        rg = GetComponent<Rigidbody>(); //获取主角钢体组件
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
