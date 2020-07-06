
using UnityEngine;

public class TvPuzzle : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] TvKnob channelKnob = null;
    [SerializeField] TvKnob volumeKnob = null;
    [SerializeField] SpriteRenderer solvedChannel = null;

    bool isSolved = false;

    [Header("Attributes")]
    [SerializeField] [Range(0, 10)] int correctVolume = 0;
    [SerializeField] [Range(0, 10)] int correctChannel = 0;

    void Update()
    {
        if (!isSolved && 
            channelKnob && channelKnob.CurState == correctChannel && 
            volumeKnob && volumeKnob.CurState == correctVolume)
        {
            isSolved = true;
            channelKnob.Deactivate();
            volumeKnob.Deactivate();
            solvedChannel.gameObject.SetActive(true);
        }
    }
}
