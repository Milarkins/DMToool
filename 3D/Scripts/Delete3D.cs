using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete3D : MonoBehaviour
{
    public bool canRotate;
    void OnMouseDrag()
    {
        if(Input.GetKeyDown(KeyCode.R) && canRotate) transform.Rotate(0f, 90f, 0f);
        if(Input.GetKeyDown(KeyCode.Backspace)) Destroy(gameObject);
    }
}
