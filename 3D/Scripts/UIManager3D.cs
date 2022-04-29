using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using TMPro;

public class UIManager3D : MonoBehaviour
{
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();
    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
    private const int SW_MINIMIZE = 6;

    public TMP_InputField hex;
    public void changeBG()
    {
        string hexCode = hex.text;
        Color color;
        ColorUtility.TryParseHtmlString(hexCode, out color);
        Camera.main.backgroundColor = color;
    }

    public void Mini()
    {
        var hwnd = GetActiveWindow();
        ShowWindow(hwnd, SW_MINIMIZE);
    }

    public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
