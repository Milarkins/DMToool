using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridVisual : MonoBehaviour
{
    Camera cam;
    float height, width;
    SpriteRenderer sr;
    void Start()
    {
        cam = Camera.main;
        height = 2f * cam.orthographicSize;
        width = height * cam.aspect;
        sr = GetComponent<SpriteRenderer>();
        sr.drawMode = SpriteDrawMode.Tiled;
        sr.enabled = true;
    }
    void Update()
    {
        sr.size = new Vector2(width,height);
    }
}
