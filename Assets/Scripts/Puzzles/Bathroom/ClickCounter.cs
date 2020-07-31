using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    [SerializeField] BikeLock bikelock = null;
 //   [SerializeField] string digit = "1";
    int counter = 0;

    void OnMouseDown()
    {
       if (bikelock)
       {
            //increase counter by 1 when clicked
            //aka flip the lock to the next number
            counter = counter + 1;
            if (counter > 9)
            {
                //reset the lock when you hit 10
                counter = 0;
            }


            //send off the input to this slider to the full
            //bikelock script
            bikelock.AddDigit(counter.ToString());
       }
    }
}
