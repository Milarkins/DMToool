using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorhex : MonoBehaviour
{
    public UIManager ui;
    public Image img;
    void Update()
    {
        string hexCode = ui.htag + ui.hex.text;
        Color color;
        ColorUtility.TryParseHtmlString(hexCode, out color);
        img.color = color;
    }
}
