using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marker3D : MonoBehaviour
{
    public GameObject Name;
    public Image img;
    public Color[] colorlist;
    bool nToggle = false;
    int colorNum = 0;
    void Update()
    {
        if(nToggle) Name.SetActive(true);
        else Name.SetActive(false);

        if(colorNum >= colorlist.Length) colorNum = 0;
        img.color = colorlist[colorNum];
    }

    void OnMouseDrag()
    {
        if(Input.GetKeyDown(KeyCode.N)) nToggle = !nToggle;
        if(Input.GetKeyDown(KeyCode.A)) colorNum++;
    }
}
