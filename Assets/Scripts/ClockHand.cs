using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand : MonoBehaviour
{
    [SerializeField]bool isHour;

    void OnMouseDown()
    {
        transform.eulerAngles = new Vector3(0, 0, (transform.rotation.eulerAngles.z - 30));
    }
}
