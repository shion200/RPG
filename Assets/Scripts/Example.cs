using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static changescene;

public class Example : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    
    public void Start()
    {
        Debug.Log(tempx);
        Debug.Log(tempy);
        Debug.Log(tempz);
        x = tempx;
        y = tempy;
        z = tempz;
        this.transform.position = new Vector3(x,y,z-1);
    }
}