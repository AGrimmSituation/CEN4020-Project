using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    [SerializeField] BikeLock bikelock = null;
    [SerializeField] BikeLock.Digit digit = BikeLock.Digit.Left;

    void OnMouseDown()
    {
       if (bikelock)
       {
            bikelock.IncrementDigit(digit);
       }
    }
}
