using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    //public float x_speed_translate = 100f;
    public float x_speed_translate = 120f;
    //public float x_speed_rotation = 40f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * Time.deltaTime * x_speed_translate);
       //transform.Translate(Vector3.right * Time.deltaTime * x_speed_translate);
    }
}
