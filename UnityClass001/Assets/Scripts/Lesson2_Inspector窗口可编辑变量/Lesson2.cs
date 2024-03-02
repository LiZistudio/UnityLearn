using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Color {
    yellow,
    green,
    blue,
}

[System.Serializable]
public class MyClass {
    public uint age;
    public double hight;
}
public class Lesson2 : MonoBehaviour {
    
    [SerializeField]
    private uint _privateInt = 10;
    [HideInInspector]
    public int _privateInt2 = 10;
    public bool _button1 = true;
    public string _name = "Lesson2";
    public string Name {
        get {
            return _name;
        }

        set {
            _name = value;
        }
    }

    public int[] array;
    public List<int> arrayList;
    public Color color;
    public GameObject gameObj;

    [Header("基础属性")]
    public int _age;
    public double _weight;
    [Header("战斗属性")]
    public double _fire;
    public double _define;

    [Space()]
    public MyClass myClass;

    [Range(0,100)]
    public double _strong;
    // Start is called before the first frame update
    protected void Start() {
        print($"{Name}");
        print($"{_privateInt}");
    }

    // Update is called once per frame
    protected void Update() {

    }
}
