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
    // 图片与范围偏移量，图片之间的偏移量为此偏移量减10,Test39之后使用GridLayoutGroup和ContentSizeFitter来进行布局管理
    // public Vector2 offset = new Vector2(30, 30);
    // 图片的尺寸大小，Test39之后使用GridLayoutGroup和ContentSizeFitter来进行布局管理
    // public Vector2 itemSize;
    
    private void Start()
    {
        buttonCloseBagPanel.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
        });
        for (int i = 0; i < itemNum; i++)
        {
            GameObject item = Instantiate(Resources.Load<GameObject>("Item"), scrollView.content);
            // 设置item的位置,Test39之后改用GridLayoutGroup组件控制排列
            // item.transform.localPosition = new Vector3(i % 4 * (itemSize.x + offset.x - 10) + offset.x, -(i / 4 * (itemSize.x + offset.y - 10) + offset.y), 0);
        }
        
        // 设置content大小，Test39之后改用ContentSizeFitter控制大小变换
        // scrollView.content.sizeDelta = new Vector2(0, Mathf.CeilToInt(itemNum / 4f) * (itemSize.x + offset.y - 10) + offset.y);
        
        gameObject.SetActive(false);
    }
}
