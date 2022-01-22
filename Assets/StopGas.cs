using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class StopGas : MonoBehaviour
{
    // Start is called before the first frame update
    private float x_max = 5;
    private float x_min = -5;
    private float mul = 1;
    private float x_speed = 0.05f;
    private string folder = "ScreenshotFolder";
    private int frameRate = 25;
    private float delta_Time = 0;
    private DateTime currentTime = DateTime.Now;
    private float sumTime = 0;
    private float stopTime = 10;

    void TimeMoving()
    {
        delta_Time = Time.deltaTime;
        currentTime = DateTime.Now;
        sumTime += delta_Time;
    }

    void Start()
    {
        Time.captureFramerate = frameRate;
        System.IO.Directory.CreateDirectory(folder);
    }

    // Update is called once per frame
    void Update()
    {
        string name = string.Format("{0}/{1:D04} shot.png", folder, Time.frameCount);


        transform.position = transform.position + mul * new Vector3(x_speed, 0, 0);
        if (transform.position.x >= 0 )
        {
            if(transform.position.x >= 0 && transform.position.x <= 0.2)
            {
                x_speed = 0;
                TimeMoving();
                if(sumTime > stopTime)
                {
                    x_speed = 0.05f;
                }
            }
        }
        if (transform.position.x >= x_max)
        {
            mul = 1;
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.y = 0;
            transform.rotation = Quaternion.Euler(rotationVector);
            x_speed = 0;
        }
        // Capture the screenshot to the specified file.
        ScreenCapture.CaptureScreenshot(name);
    }

    void SetTransformX(float n)
    {
        transform.position = new Vector3(n, transform.position.y, transform.position.z);
    }
}
