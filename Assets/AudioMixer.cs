using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioMixers : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        Debug.Log(volume);
    }
}