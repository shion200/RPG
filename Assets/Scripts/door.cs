using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public Transform other;
    void Start()
    {
        
    }
    void Update()
    {
        float A = Vector3.Distance(other.position ,transform.position);
        if(A<=2)
        {
            if (Input.GetMouseButtonDown(1))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
