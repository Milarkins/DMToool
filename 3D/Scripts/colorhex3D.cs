using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class colorhex3D : MonoBehaviour
{
    public TMP_InputField hex;
    private Image img;
    void Start()
    {
        img = GetComponent<Image>();
    }
    void Update()
    {
        string hexCode = hex.text;
        Color color;
        ColorUtility.TryParseHtmlString(hexCode, out color);
        img.color = color;
    }
}
