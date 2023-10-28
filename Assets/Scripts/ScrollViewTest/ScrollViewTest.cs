using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewTest : MonoBehaviour
{
    public Button buttonOpenBagPanel;
    public RectTransform bagPanel;

    void Start()
    {
        buttonOpenBagPanel.onClick.AddListener(() =>
        {
            bagPanel.gameObject.SetActive(true);
        });
    }
}
