using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;

    private const float degreesPerHour = 30;
    private const float degreesPerMinute = 6;
    private const float degreesPerSecond = 6;
    public bool continuous;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }

    private void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursTransform.localRotation =
            Quaternion.Euler(0, (float)time.TotalHours * degreesPerHour, 0);
        minutesTransform.localRotation =
            Quaternion.Euler(0, (float)time.TotalMinutes * degreesPerMinute, 0);
        secondsTransform.localRotation =
            Quaternion.Euler(0, (float)time.TotalSeconds * degreesPerSecond, 0);
    }

    private void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation =
            Quaternion.Euler(0, time.Hour * degreesPerHour, 0);
        minutesTransform.localRotation =
            Quaternion.Euler(0, time.Minute * degreesPerMinute, 0);
        secondsTransform.localRotation =
            Quaternion.Euler(0, time.Second * degreesPerSecond, 0);
    }
}