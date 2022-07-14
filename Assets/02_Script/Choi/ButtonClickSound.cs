using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void Play()
    {

           _audioSource.Play();

    }

}
