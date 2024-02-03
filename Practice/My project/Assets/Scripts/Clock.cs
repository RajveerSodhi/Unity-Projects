using UnityEngine;
using System;

public class Clock: MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    void Update() {
        TimeSpan currentTime = DateTime.Now.TimeOfDay;
        Debug.Log(currentTime);
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, (hoursToDegrees * (float) currentTime.TotalHours));
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float) currentTime.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float) currentTime.TotalSeconds);

    }

}