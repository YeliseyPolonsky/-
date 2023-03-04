using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource _audioSource;
    private GameObject _library;

    private void Start()
    {
        _library = FindAnyObjectByType<Library>().gameObject;
        _audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        _library.GetComponent<Library>().StopAllSouns();
        _audioSource.Play();
    }
}
