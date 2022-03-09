using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformations : MonoBehaviour
{

    

    
    // Start is called before the first frame update
    void Start()
    {
        ////a posição
        Debug.Log("X =" + transform.position.x);
        Debug.Log("Y =" + transform.position.y);
        Debug.Log("Z =" + transform.position.z);

        ////a rotação
        Debug.Log("X =" + transform.localEulerAngles.x);
        Debug.Log("Y =" + transform.localEulerAngles.y);
        Debug.Log("Z =" + transform.localEulerAngles.z);

        ////a rotação global
        Debug.Log("X =" + transform.eulerAngles.x);
        Debug.Log("Y =" + transform.eulerAngles.y);
        Debug.Log("Z =" + transform.eulerAngles.z);

        ////scale global
        Debug.Log("X =" + transform.localScale.x);
        Debug.Log("Y =" + transform.localScale.y);
        Debug.Log("Z =" + transform.localScale.z);


        transform.Translate(Vector3.down * Time.deltaTime, Space.World);


    }
    // Update is called once per frame
    void Update()
    {





    }
}


