using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldTest : MonoBehaviour
{
    public Button buttonChangeName;
    public Text Name;
    public RectTransform ChangeNamePanel;

    private void Start()
    {
        buttonChangeName.onClick.AddListener(() =>
        {
            ChangeNamePanel.gameObject.SetActive(true);
        });
        Name.text = "姓名：默认";
        ChangeNamePanel.gameObject.SetActive(false);
    }
}
