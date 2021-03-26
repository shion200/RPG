using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class comments : MonoBehaviour {
    public Transform other;
    public GameObject image;
    bool One;

    void Start()
    {
        One = false;
    }

    void Update(){
        float A = Vector3.Distance(other.position ,transform.position);
        // Debug.Log(A);
        if(One)
        {
            GameObject bullet = Instantiate(image, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
            One = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            if(A<=2)
            {
                One = true;
            }
        }

    }
}
