using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{
    public RectTransform hpBg;
    public RectTransform hp;
    public UIEventListenTest listener;
    public Text hpText;
    public float hpSpeed = 10;

    private bool isDown = false;
    private float timer = 0;
    private int ihp = 0;
    private void Start()
    {
        listener.downEvent.AddListener(OnDown);
        listener.upEvent.AddListener(OnUp);
        hpBg.gameObject.SetActive(false);
        hpText.text = "当前HP:" + ihp;
    }

    private void Update()
    {
        if (isDown)
        {
            if (timer < 0.2f)
            {
                timer += Time.deltaTime;
            }
            else
            {
                hp.sizeDelta = new Vector2(hp.sizeDelta.x + hpSpeed * Time.deltaTime, hp.sizeDelta.y);
                if (hp.sizeDelta.x >= hpBg.sizeDelta.x)
                {
                    ihp += 10;
                    hpText.text = "当前HP:" + ihp;
                    hp.sizeDelta = new Vector2(0, hp.sizeDelta.y);
                }
            }
        }
        else if (!isDown && hp.sizeDelta.x > 0)
        {
            hp.sizeDelta = new Vector2(hp.sizeDelta.x - hpSpeed * Time.deltaTime, hp.sizeDelta.y);
            if (hp.sizeDelta.x <= 0)
            {
                hp.sizeDelta = new Vector2(0, hp.sizeDelta.y);
            }
        }
        else if (!isDown && hp.sizeDelta.x == 0)
        {
            hpBg.gameObject.SetActive(false);
        }
    }

    private void OnDown()
    {
        hpBg.gameObject.SetActive(true);
        isDown = true;
    }

    private void OnUp()
    {
        timer = 0;
        isDown = false;
    }
}
