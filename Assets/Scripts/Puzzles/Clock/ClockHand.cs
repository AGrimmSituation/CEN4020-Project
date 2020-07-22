using UnityEngine;

public class ClockHand : MonoBehaviour
{
    // Inspector Variables
    [SerializeField] bool isHoursHand = false;

    bool operatable = true;

    // Returns the time the hand is currently indicating.
    public int Value
    {
        get
        {
            if (isHoursHand) // If the hand is the hours hand, return value in-between 1 and 12.
            {
                return (int)(360 - ((int)transform.eulerAngles.z + 360) % 360) / 30;
            }
            else // If the hand is the minutes hand, return value in-between 0 and 59.
            {
                return ((int)(360 - ((int)transform.eulerAngles.z + 360) % 360) / 6) % 60;
            }
        }
    }

    void OnMouseDown()
    {
        // Rotates the hand one tick clockwise.
        if (operatable)
        {
            transform.eulerAngles = new Vector3(0, 0, (transform.rotation.eulerAngles.z - 30));
        }
    }

    public void SetAndLock (int time)
    {
        operatable = false;
        transform.eulerAngles = new Vector3(0, 0, 360 - (time * (isHoursHand ? 1 : 5)) * 30);
    }
}
