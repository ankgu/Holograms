using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class zAnimator : MonoBehaviour {

    private DateTime LastTimeChangedVelocity;
    public float zVelocity;
    public double IntervalToSwitchvelocityDirection;

	// Use this for initialization
	void Start () {
        LastTimeChangedVelocity = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
        var CurrentTime = DateTime.Now;
        TimeSpan timeSpan = CurrentTime.Subtract(LastTimeChangedVelocity);
        if(timeSpan.TotalMilliseconds > IntervalToSwitchvelocityDirection)
        {
            LastTimeChangedVelocity = CurrentTime;
            zVelocity *= -1.0f;
        }

        transform.Translate(zVelocity/30.0f, 0, 0);
	}
}
