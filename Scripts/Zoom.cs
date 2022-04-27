using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private Camera cam;
    private int zoomAmt = 6;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if(zoomAmt < 4) zoomAmt = 4;
        if(zoomAmt > 10) zoomAmt = 10;
        if(Input.GetKeyDown(KeyCode.Equals)) zoomAmt--;
        if(Input.GetKeyDown(KeyCode.Minus)) zoomAmt++;

        cam.orthographicSize = zoomAmt;
    }
}
