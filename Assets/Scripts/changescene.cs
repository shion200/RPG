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

        if (C.transform.position.x <= -27 && C.transform.position.x >= -30)
        {
            if (C.transform.position.z <= -0.5 && C.transform.position.z >= -1.5)
            {
                SceneManager.LoadScene("interier1");
            }
        }
        
        if (C.transform.position.x <= 24 && C.transform.position.x >= 21)
        {
            if (C.transform.position.z <= -0.5 && C.transform.position.z >= -1.5)
            {
                SceneManager.LoadScene("interier2");
            }
        }

        if (C.transform.position.x <= -9  && C.transform.position.x >= -12)
        {
            if (C.transform.position.z <= -30.5 && C.transform.position.z >= -31.5)
            {
                SceneManager.LoadScene("interier3");
            }
        }

        if (C.transform.position.x <=15.5  && C.transform.position.x >= 12.5)
        {
            if (C.transform.position.z <= 30.5 && C.transform.position.z >= 29.5)
            {
                SceneManager.LoadScene("interier4");
            }
        }

        if (C.transform.position.x <=-9  && C.transform.position.x >= -12)
        {
            if (C.transform.position.z <= 30.5 && C.transform.position.z >= 29.5)
            {
                SceneManager.LoadScene("interier5");
            }
        }

        if (C.transform.position.x <=15.5  && C.transform.position.x >= 12.5)
        {
            if (C.transform.position.z <= -30.5 && C.transform.position.z >= -31.5)
            {
                SceneManager.LoadScene("interier6");
            }
        }
    }
}
