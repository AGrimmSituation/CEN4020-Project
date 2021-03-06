﻿using UnityEngine;

public class TvPuzzle : MonoBehaviour
{
    [Header("Scene References")]
    [SerializeField] TvKnob channelKnob = null;
    [SerializeField] TvKnob volumeKnob = null;
    [SerializeField] SpriteRenderer solvedChannel = null;
    [SerializeField]GameObject roomTVScreen = null;

    [Header("Attributes")]
    [SerializeField] [Range(0, 10)] int correctVolume = 0;
    [SerializeField] [Range(0, 10)] int correctChannel = 0;

    bool isSolved = false;
    public bool IsSolved { get => isSolved; }

    void Update()
    {
        // Channel Knob and Volume Knob must be attached to check for solution.
        if (!isSolved && channelKnob && volumeKnob)
        {
            if (channelKnob.CurState == correctChannel && volumeKnob && volumeKnob.CurState == correctVolume)
            {
                SolveAndLock();
            }
        }
    }

    public void SolveAndLock()
    {
        isSolved = true;
        channelKnob.SetAndLock(correctChannel);
        volumeKnob.SetAndLock(correctVolume);
        solvedChannel.gameObject.SetActive(true);
        roomTVScreen.gameObject.SetActive(true);
        SavedState.tvSolved = true;
    }
}

