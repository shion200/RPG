using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public GameObject C;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (C.transform.position.x <= 1.5 && C.transform.position.x >= -1.5)
        {
            if (C.transform.position.z <= -0.5 && C.transform.position.z >= -1.5)
            {
                SceneManager.LoadScene("interier");
            }
        }

        // if (C.transform.position.x <= -27 && C.transform.position.x >= -30)
        // {
        //     if (C.transform.position.z <= -0.5 && C.transform.position.z >= -1.5)
        //     {
        //         SceneManager.LoadScene("")
        //     }
        // }
    }
}
