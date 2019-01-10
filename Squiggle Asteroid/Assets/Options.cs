using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour {

    public AudioMixer audioMixer;

    //connects audio mixer to slider
    public void Sound(float sound)
    {
        audioMixer.SetFloat("volume", sound);
    }
}
