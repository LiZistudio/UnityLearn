using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestScript : MonoBehaviour {
    public string readme = "author:cuiwei;guanxinliangshiheshucai@outlook.com";
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Starting");
        TestScript.print("name:"+this.name);
        TestScript.print("position:"+this.transform.position);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
