using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marker3D : MonoBehaviour
{
    public GameObject Name, incom;
    public Image img;
    public Color[] colorlist;
    bool nToggle = false, iToggle = false;
    int colorNum = 0;
    void Update()
    {
        if(nToggle) Name.SetActive(true);
        else Name.SetActive(false);

        if(iToggle) incom.SetActive(true);
        else incom.SetActive(false);

        if(colorNum >= colorlist.Length) colorNum = 0;
        img.color = colorlist[colorNum];
    }

    void OnMouseDrag()
    {
        if(Input.GetKeyDown(KeyCode.N)) nToggle = !nToggle;
        if(Input.GetKeyDown(KeyCode.I)) iToggle = !iToggle;
        if(Input.GetKeyDown(KeyCode.A)) colorNum++;
    }
}
