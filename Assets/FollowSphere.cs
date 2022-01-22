using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSphere : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 50f;
    public Transform target;
    public float smooth = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,target.position,Time.deltaTime * smooth);
    }
}
