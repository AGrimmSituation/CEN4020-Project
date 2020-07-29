using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticHandler : MonoBehaviour
{
    [SerializeField]AudioSource sound = null;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.playOnAwake = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(SavedState.tvSolved == true)
        {
            sound.playOnAwake = false;
            sound.loop = false;
            sound.Stop();
        }
    }
}
