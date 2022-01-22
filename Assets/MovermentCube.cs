using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovermentCube : MonoBehaviour
{
    public float x_speed = 5f;
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move object follow to arrow
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //Vector3 v = new Vector3(-x_speed,transform.position.y,transform.position.z);
            transform.Translate(Vector3.left * (Time.deltaTime * x_speed) );
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * (Time.deltaTime * x_speed));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * (Time.deltaTime * x_speed));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * (Time.deltaTime * x_speed));
        }
    }
}
