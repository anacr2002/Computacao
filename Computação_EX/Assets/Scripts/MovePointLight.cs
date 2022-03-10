using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointLight : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Position = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Horizontal"));
    }
}
