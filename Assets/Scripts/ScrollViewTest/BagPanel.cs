using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagPanel : MonoBehaviour
{
    public Button buttonCloseBagPanel;
    public ScrollRect scrollView;
    public int itemNum = 40;
    public Vector2 offset = new Vector2(30, 30);
    public Vector2 itemSize;
    
    private void Start()
    {
        buttonCloseBagPanel.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
        });
        for (int i = 0; i < itemNum; i++)
        {
            GameObject item = Instantiate(Resources.Load<GameObject>("Item"), scrollView.content);
            item.transform.localPosition = new Vector3(i % 4 * (itemSize.x + offset.x - 10) + offset.x, -(i / 4 * (itemSize.x + offset.y - 10) + offset.y), 0);
        }

        scrollView.content.sizeDelta = new Vector2(0, Mathf.CeilToInt(itemNum / 4f) * (itemSize.x + offset.y - 10) + offset.y);
        
        gameObject.SetActive(false);
    }
}
