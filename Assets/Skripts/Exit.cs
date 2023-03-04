using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Exit : MonoBehaviour
{
    [SerializeField] private GameObject _backGround;
    [SerializeField] private GameObject _canvas;
    public void ExitButton()
    {
        foreach (var item in GameObject.FindGameObjectsWithTag("Video"))
        {
            item.GetComponent<VideoPlayer>().enabled = false;
        }

        _canvas.SetActive(true);
        _backGround.SetActive(true);
    }
}
