using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

    public Transform hoursArm, minutesArm, secondsArm;

    private const float degreesPerHour = 30f;
    private const float degreesPerMinute = 6f;
    private const float degreesPerSecond = 6f;

    private void Awake()
    {
        var time = DateTime.Now;
        hoursArm.localRotation = Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minutesArm.localRotation = Quaternion.Euler(0f, time.Minute * degreesPerMinute, 0f);
        secondsArm.localRotation = Quaternion.Euler(0f, time.Second * degreesPerSecond, 0f);
    }
}
