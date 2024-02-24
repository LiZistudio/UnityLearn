using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DanceCube : MonoBehaviour {
    public GameObject _whiteCube;
    double _whiteCubeRoY;
    private double _rotationY;
    public double RotationY { get { return _rotationY; } }
    // Start is called before the first frame update
    void Start() {
        _rotationY = this.transform.rotation.y;
        Debug.Log(_rotationY);
        _whiteCubeRoY = _whiteCube.transform.rotation.y;
        Debug.Log(_whiteCubeRoY);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
