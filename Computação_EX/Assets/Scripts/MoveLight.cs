using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight : MonoBehaviour
{
    // Start is called before the first frame update
    public float DayLenght;

    public float rotation;

    Light luz;

    Color lerpedColor = Color.white;
    void Start()
    {
        luz = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {
        rotation = Time.deltaTime + 0.5f;
        transform.Rotate(0, rotation, 0);
        lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
        
    }
}
