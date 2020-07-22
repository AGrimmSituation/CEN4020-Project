using UnityEngine;

public class Clock : MonoBehaviour
{
    // Scene References
    [SerializeField] ClockHand hoursHand = null;
    [SerializeField] ClockHand minHand = null;

    // Attributes
    [SerializeField] int correctHours = 0;
    [SerializeField] int correctMinutes = 0;

    [SerializeField] GameObject door = null;

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
            SolveAndLock();
        }
    }

    public void SolveAndLock()
    {
        hoursHand.SetAndLock(correctHours);
        minHand.SetAndLock(correctMinutes);
        //Enable the collider for the attached door, making it usable. Added 7/7/20 10:52PM
        door.GetComponent<BoxCollider2D>().enabled = true;
        solved = true;
        gameObject.SetActive(false);
    }
}
