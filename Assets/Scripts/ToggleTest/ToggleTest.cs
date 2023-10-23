using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTest : MonoBehaviour
{
    private static ToggleTest instance;
    public static ToggleTest Instance => instance;
    private bool isPlay;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Toggle toggle;
        if (TryGetComponent<Toggle>(out toggle))
        {
            toggle.onValueChanged.AddListener(ChangeSoucePlay);
            isPlay = toggle.isOn;
        }
    }

    public void PlayAudio(AudioSource audio)
    {
        audio.mute = !isPlay;
        audio.Play();
    }

    private void ChangeSoucePlay(bool isOn)
    {
        isPlay = isOn;
    }
}