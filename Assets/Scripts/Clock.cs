using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]GameObject hourHand = null;
    [SerializeField]GameObject minHand = null;

    public struct ourTime
    {
        public int hours;
        public int minutes;

        public ourTime(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
    }

    public ourTime GetTime()
    {
        Debug.Log(hourHand.transform.eulerAngles.z + " " + minHand.transform.eulerAngles.z);
        int hours = (int)(360 - (hourHand.transform.eulerAngles.z + 0.5f + 360)% 360) / 30;
        int minutes = (int)(360 - (minHand.transform.eulerAngles.z + 0.5f + 360)% 360) / 6;
        return (new ourTime(hours, minutes));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log(GetTime().hours + ":" + GetTime().minutes);
        }
    }
}
