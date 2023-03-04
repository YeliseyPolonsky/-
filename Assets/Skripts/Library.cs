using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MonoBehaviour
{
    private GameObject[] _sounds;

    void Start()
    {
        _sounds = GameObject.FindGameObjectsWithTag("Sound");
    }

    public void StopAllSouns()
    {
        foreach (GameObject sound in _sounds)
        {
            sound.GetComponent<AudioSource>().Stop();
        }
    }  
}
