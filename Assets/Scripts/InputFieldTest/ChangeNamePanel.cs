using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNamePanel : MonoBehaviour
{
    public Text _name;
    public InputField input;
    public Button enterButton;

    private void OnEnable()
    {
        input.text = "";
    }

    private void Start()
    {
        enterButton.onClick.AddListener(() =>
        {
            if (input.text != "")
            {
                _name.text = "姓名：" + input.text;
                gameObject.SetActive(false);
            }
        });
        input.onSubmit.AddListener((s) =>
        {
            if (input.text != "")
            {
                _name.text = "姓名：" + s;
                gameObject.SetActive(false);
            }
        });
    }
}