using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour {
    //知识点三：生命周期函数

    //出生时调用(当该脚本对象被创建时)，类似构造函数，一个对象只会调用一次。
    protected virtual void Awake() {      
        print("Awake");
        Debug.Log("Awake");
        //Debug.LogError("Error!");
        //Debug.LogWarning("Warning!");
    }

    //依附的GameObject对象每次被激活时调用
    private void OnEnable() {   
        print("OnEnable");
    }

    //从自己被创建出来后，第一次帧更新之前调用，一个对象只会调用一次
    private void Start() {
        print("Start");     
    }

    //它主要适用于物理更新
    //他是每一帧都执行的，但是这里的帧和游戏帧有点不同
    private void FixedUpdate() {
        print("FixedUpdate");
    }

    //主要用于处理游戏核心逻辑更新的函数
    private void Update() {     
        print("Update");
    }

    //一般这个更新是用来处理摄像机位置更新相关的内容的
    //Update和LateUpdate之间Unity进行了一些处理，处理我们动画相关的更新
    private void LateUpdate() {
        print("LateUpdate");
    }

    //依附的GameObject对象每次失活时调用
    private void OnDisable() {
        print("OnDisable");
    }

    //对象销毁时调用
    //依附的GameObject对象被删除时
    private void OnDestroy() {
        print("OnDestroy");
    }
}