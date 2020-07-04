﻿using UnityEngine;

public class Clock : MonoBehaviour
{
    // Scene References
    [SerializeField] ClockHand hoursHand = null;
    [SerializeField] ClockHand minHand = null;

    // Attributes
    [SerializeField] int correctHours = 0;
    [SerializeField] int correctMinutes = 0;

    bool solved = false;

    // Represents time with integer hours and minutes.
    public struct Time
    {
        public int hours;
        public int minutes;

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
    }

    // The time the clock's hands are currently pointing to.
    public Time CurTime { get => new Time(hoursHand.Value, minHand.Value); }

    void Update()
    {
        // DEBUG. Check the time the clock's hands are currently pointing to by pressing the X key.
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log(CurTime.hours + ":" + CurTime.minutes);
        }

        // If the time is correct, lock the clock.
        if (CurTime.hours == correctHours && CurTime.minutes == correctMinutes && !solved)
        {
            hoursHand.operatable = false;
            minHand.operatable = false;
            gameObject.SetActive(false);
            solved = true;
        }
    }
}