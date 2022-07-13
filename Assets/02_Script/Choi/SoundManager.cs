using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioClip[] clip;
    [SerializeField] private AudioSource source;
    [SerializeField] private float Delay;

    private void Start()
    {

        StartCoroutine(Change());

    }

    IEnumerator Change()
    {

        source.clip = clip[0];
        source.Play();

        yield return new WaitForSeconds(Delay);

        source.clip = clip[1];

        source.Play();

        source.loop = true;

    }

}
