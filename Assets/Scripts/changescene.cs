using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public GameObject C;
    public static float tempx = 3;
    public static float tempy = 0;
    public static float tempz = -5;
    public void Start()
    {
    //    ball = GameObject.Find("unitychan_dynamic_locomotion");
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (C.transform.position.x <= 1.5 && C.transform.position.x >= -1.5)
        {
            if (C.transform.position.z <= -0.5 && C.transform.position.z >= -1.5)
            {
                tempx = C.transform.position.x;
                tempy = C.transform.position.y; 
                tempz = C.transform.position.z;
                // Debug.Log(tempx);
                // Debug.Log(tempy);
                // Debug.Log(tempz);
                SceneManager.LoadScene("interier");
            }
        }

        if (C.transform.position.x <= -27 && C.transform.position.x >= -30)
        {
            if (C.transform.position.z <= -0.5 && C.transform.position.z >= -1.5)
            {
                tempx = C.transform.position.x;
                tempy = C.transform.position.y; 
                tempz = C.transform.position.z;
                // Debug.Log(tempx);
                // Debug.Log(tempy);
                // Debug.Log(tempz);
                SceneManager.LoadScene("interier1");
            }
        }
        
        if (C.transform.position.x <= 24 && C.transform.position.x >= 21)
        {
            if (C.transform.position.z <= -0.5 && C.transform.position.z >= -1.5)
            {
                tempx = C.transform.position.x;
                tempy = C.transform.position.y; 
                tempz = C.transform.position.z;
                // Debug.Log(tempx);
                // Debug.Log(tempy);
                // Debug.Log(tempz);
                SceneManager.LoadScene("interier2");
            }
        }

        if (C.transform.position.x <= -9  && C.transform.position.x >= -12)
        {
            if (C.transform.position.z <= -30.5 && C.transform.position.z >= -31.5)
            {
                tempx = C.transform.position.x;
                tempy = C.transform.position.y; 
                tempz = C.transform.position.z;
                // Debug.Log(tempx);
                // Debug.Log(tempy);
                // Debug.Log(tempz);
                SceneManager.LoadScene("interier3");
            }
        }

        if (C.transform.position.x <=15.5  && C.transform.position.x >= 12.5)
        {
            if (C.transform.position.z <= 30.5 && C.transform.position.z >= 29.5)
            {
                tempx = C.transform.position.x;
                tempy = C.transform.position.y; 
                tempz = C.transform.position.z;
                // Debug.Log(tempx);
                // Debug.Log(tempy);
                // Debug.Log(tempz);
                SceneManager.LoadScene("interier4");
            }
        }

        if (C.transform.position.x <=-9  && C.transform.position.x >= -12)
        {
            if (C.transform.position.z <= 30.5 && C.transform.position.z >= 29.5)
            {
                tempx = C.transform.position.x;
                tempy = C.transform.position.y; 
                tempz = C.transform.position.z;
                // Debug.Log(tempx);
                // Debug.Log(tempy);
                // Debug.Log(tempz);
                SceneManager.LoadScene("interier5");
            }
        }

        if (C.transform.position.x <=15.5  && C.transform.position.x >= 12.5)
        {
            if (C.transform.position.z <= -30.5 && C.transform.position.z >= -31.5)
            {
                tempx = C.transform.position.x;
                tempy = C.transform.position.y; 
                tempz = C.transform.position.z;
                // Debug.Log(tempx);
                // Debug.Log(tempy);
                // Debug.Log(tempz);
                SceneManager.LoadScene("interier6");
            }
        }
    }
    public static float getX(){
        return tempx;
    } 

    public static float getY(){
        return tempy;
    }

    public static float getZ(){
        return tempz;
    }


}
