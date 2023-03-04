using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information : MonoBehaviour
{
    [SerializeField] GameObject _infoButton;

    public void Activizate()
    {
        gameObject.SetActive(true);
        _infoButton.SetActive(false);
    }

    public void Off()
    {
        gameObject.SetActive(false);
        _infoButton.SetActive(true);
    }
}
