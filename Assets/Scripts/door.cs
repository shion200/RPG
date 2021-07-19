using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using static changescene;

public class door : MonoBehaviour
{
    public Transform other;
    public GameObject C;
    // public float x;
    // public float y;
    // public float z;
    // public GameObject ball;
    public void Start()
    {
    //     SampleSingleton.instance.subroutine();
        // changescene a = ball.GetComponent<changescene>();
        // x = changescene.getX();
        // y = changescene.getY();
        // z = changescene.getZ();
    }
    void Update()
    {
        float A = Vector3.Distance(other.position ,transform.position);
        if(A<=2)
        {
            if (Input.GetMouseButtonDown(1))
            {
                SceneManager.LoadScene("SampleScene");
                // C.transform.position = new Vector3(x,y,z);
                // // Debug.Log(x);
                // Debug.Log(y);
                // Debug.Log(z);
            }
        }
    }
}
