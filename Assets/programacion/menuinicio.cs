using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuinicio : MonoBehaviour {
    Transform mTransform;

    // Use this for initialization
    void Start () {
        mTransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {

        mTransform.eulerAngles += (new Vector3(0, 0.7f, 0)); 
        


    }
}
