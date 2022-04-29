using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDrag : MonoBehaviour
{
    public float zz;
    void OnMouseDrag()
    {
        transform.position = GetMousePos();
        if(Input.GetKeyDown(KeyCode.Backspace)) Destroy(gameObject);
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = zz;
        return mousePos;
    }
}
