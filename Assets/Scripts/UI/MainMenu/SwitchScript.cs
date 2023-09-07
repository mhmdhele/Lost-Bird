using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    public AudioSource audioSource;

    public void SwitchSF()
    {
        audioSource.Play();
    }
}
