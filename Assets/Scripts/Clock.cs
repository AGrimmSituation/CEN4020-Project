using UnityEngine;

public class Clock : MonoBehaviour
{
    // Scene References
    [SerializeField] ClockHand hoursHand = null;
    [SerializeField] ClockHand minHand = null;

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
    }
}
