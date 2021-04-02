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
            var obj = Instantiate(image, new Vector3( -1.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;
            obj.name = image.name;
            One = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameObject bullet = GameObject.Find("MessageUI");
            if(bullet == null)
            {
                // Debug.Log("true");
                if(A<=2)
                {
                    One = true;
                }
            }
            else
            {
                // Debug.Log("false");
                Destroy(bullet);
            }
        }
    }
}
