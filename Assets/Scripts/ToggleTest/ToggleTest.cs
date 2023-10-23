using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTest : MonoBehaviour
{
    private ToggleGroup group;
    public Toggle toggleOn;
    public Toggle toggleOff;

    private void Start()
    {
        group = GetComponent<ToggleGroup>();
        if (SoundData.SoundOpen)
            toggleOn.isOn = true;
        toggleOn.onValueChanged.AddListener(ToggleChangeValue);
        toggleOn.onValueChanged.AddListener(ToggleChangeValue);
    }

    private void ToggleChangeValue(bool value)
    {
        foreach (Toggle toggle in group.ActiveToggles())
        {
            if (toggle == toggleOn)
                SoundData.SoundOpen = true;
            else
                SoundData.SoundOpen = false;
        }
    }
}