using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownTest : MonoBehaviour
{
    public Light _light;
    public Dropdown dropdown;
    
    void Start()
    {
        dropdown.onValueChanged.AddListener((index) =>
        {
            switch (dropdown.options[index].text)
            {
                case "白天":
                    _light.intensity = 1;
                    break;
                case "黑夜":
                    _light.intensity = 0.2f;
                    break;
            }
        });
    }
}
