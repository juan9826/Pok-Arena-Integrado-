using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientopj : MonoBehaviour {
    Transform mTransform;

    // Use this for initialization
    void Start()
    {
        mTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        mTransform.eulerAngles += (new Vector3(0, 1.0f, 0));



    }
}
