using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    public Slider soundSlider;

    private void Start()
    {
        soundSlider.value = SoundData.SoundValue;
        soundSlider.onValueChanged.AddListener((value) =>
        {
            SoundData.SoundValue = value;
        });
    }
}
