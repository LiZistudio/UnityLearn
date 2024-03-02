using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour {

    public GameObject otherGameObject;
    // Start is called before the first frame update
    void Start() {
        #region 知识点一 重要成员
        //1.获取依附的GameObject
        //GameObject gameObject1 = this.gameObject;
        print(this.gameObject.name);
        //2.获取依附的GameObject的位置信息
        print(this.transform.position);
        print(this.transform.eulerAngles);
        print(this.transform.lossyScale);
        //3.获取脚本是否激活
        this.enabled = false;
        //this.enabled = true;

        print(otherGameObject.name);
        print(otherGameObject.transform.position);
        #endregion                          

        #region 知识点二 重要方法
        //得到依附对象上挂载的其他脚本

        //1.得到自己挂载的单个脚本
        //根据脚本名获取
        Lesson3_test t = this.gameObject.GetComponent("Lesson3_test") as Lesson3_test;
        if (t != null) {
            t.enabled = false;
        }
        print(t);
        //根据Type获取
        Component t1 = this.GetComponent(typeof(Lesson3_test));
        print(t1);
        //根据泛型获取 建议使用泛型获取 因为不用二次转换
        Component t3 = this.GetComponent<Lesson3_test>();
        print(t3);
        //2.得到自己挂载的多个脚本
        Component[] t4 = this.GetComponents<Component>();
        foreach (Component c in t4) {
            print(c);
        }
        //3.得到子对象挂载的脚本(它默认也会寻找自身是否挂载该脚本)
        //得到单个子对象挂在脚本
        Component t5 = this.GetComponentInChildren<Lesson3_test>(true);
        print(t5);

        //得到多个子对象挂在脚本
        List<Lesson3_test> list = new List<Lesson3_test>();
        this.GetComponentsInChildren<Lesson3_test>(true,list);
        print(list.Count);
        //4.得到父对象挂载的脚本
        Component t6 = this.GetComponentInParent<Lesson3_test>();
        //5.尝试获取脚本
        Lesson3_test t7;
        bool res = this.TryGetComponent<Lesson3_test> (out t7);
        print(res);
        print(t7);
        #endregion
        
    }

    // Update is called once per frame
    void Update() {
        
    }

}