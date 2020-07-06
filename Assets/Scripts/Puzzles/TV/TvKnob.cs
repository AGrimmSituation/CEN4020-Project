using UnityEngine;

public class TvKnob : MonoBehaviour
{
    bool operatable = true;
    int curState = 0;
    int maxState = 10;

    public int CurState { get => curState; }

    void OnMouseDown()
    {
        if (operatable)
        {
            curState = (curState + 1) % maxState;
            transform.eulerAngles = new Vector3(0, 0, 360 * ((float)curState / (float)maxState) );
        }
    }

    public void Deactivate()
    {
        operatable = false;
    }
}
