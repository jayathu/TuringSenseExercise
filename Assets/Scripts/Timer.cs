using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    private float nextActionTime = 0.0f;
    private float period = 0.2f;
    System.DateTime time;
    bool reset;
	
	// Update is called once per frame
	void Update () {

        time = System.DateTime.Now;
        timer.text = "UTC: " + time.Hour + ":" + time.Minute + ":" + time.Second;
        if (time.Second >= nextActionTime && (int)time.Second % 2 == 0)
        {
            nextActionTime = time.Second + period;
            if(CubePool.GenerateCube != null)
            {
               CubePool.GenerateCube();
            }
            if (time.Second > 2) reset = false;
        }
        else if (!reset && time.Second == 0)
        {
            nextActionTime = 0.0f;
            reset = true;
        }
    }
}
