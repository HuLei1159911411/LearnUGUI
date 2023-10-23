using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public PlayerController player;

    private void Start()
    {
        Button button;
        if (TryGetComponent(out button))
        {
            button.onClick.AddListener(OnClick);
        }
    }

    private void OnClick()
    {
        player.Fire();
    }
}
