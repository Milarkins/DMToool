using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Marker : MonoBehaviour
{
    public GameObject Name;
    public Image img;
    public Color[] colorlist;
    bool nToggle = false;
    int colorNum = 0;
    void OnMouseDrag()
    {
        transform.position = GetMousePos();
        if(Input.GetKeyDown(KeyCode.N)) nToggle = !nToggle;
        if(Input.GetKeyDown(KeyCode.A)) colorNum++;
        if(Input.GetKeyDown(KeyCode.Backspace)) Destroy(gameObject);
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    void Update()
    {
        if(nToggle) Name.SetActive(true);
        else Name.SetActive(false);

        if(colorNum >= 5) colorNum = 0;
        img.color = colorlist[colorNum];
    }
}
