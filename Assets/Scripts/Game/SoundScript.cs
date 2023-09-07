using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlaySoundEffect()
    {
        audioSource.Play();
    }
}
