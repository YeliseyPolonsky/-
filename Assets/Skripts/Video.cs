using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _exit;
    [SerializeField] private GameObject _backGround;
    private VideoPlayer _videoPlayer;

    void Start()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.enabled = false;
        _exit.SetActive(false);
    }

    public void Play()
    {
        _videoPlayer.enabled = true;
        _canvas.SetActive(false);
        _exit.SetActive(true);
        _backGround.SetActive(false);
    }
}
