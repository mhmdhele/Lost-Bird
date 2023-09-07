using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingsScript : MonoBehaviour
{

    public AudioMixer Mixer;
    public AudioSource audioSource;
    public AudioClip clickSound;

    // Function For Change Volume
    public void SetVolume (float volume)
    {
        // Match Slider And AudioMixer Together
        Mixer.SetFloat("Sound", volume);
    }


    // Function Fot Change Quality
    public void SetQuality (int qualityIndex)
    {
        // Make The Game Quality To Index(0, 1, 2) And Access To Change Quality
        QualitySettings.SetQualityLevel(qualityIndex);
    }


    // Function For FullScreen
    public void SetFullScreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

}
