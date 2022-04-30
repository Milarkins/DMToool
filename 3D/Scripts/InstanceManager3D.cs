using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InstanceManager3D : MonoBehaviour
{
    public GameObject markerPrefab;
    public TMP_InputField hex;
    public Color[] c;
    public void AddMarker()
    {
        GameObject marker = Instantiate(markerPrefab) as GameObject;
        Renderer r = marker.GetComponent<Renderer>();
        string hexCode = hex.text;
        Color color;
        ColorUtility.TryParseHtmlString(hexCode, out color);
        r.material.color = color;
    }

    public void SetPresetColor(int i)
    {
        string hexCode = ColorUtility.ToHtmlStringRGBA( c[i] );
        hex.text = "#" + hexCode;
    }

    public void AddPrimitive(GameObject tile)
    {
        GameObject t = Instantiate(tile) as GameObject;
        Renderer r = t.GetComponent<Renderer>();
        string hexCode = hex.text;
        Color color;
        ColorUtility.TryParseHtmlString(hexCode, out color);
        r.material.color = color;
    }

    public void AddObject(GameObject tile)
    {
        Instantiate(tile);
    }
}
