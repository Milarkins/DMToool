using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSnap3D : MonoBehaviour
{
    public float yOffset;
    private void SnapToGrid()
    {
        var position = new Vector3(
            Mathf.RoundToInt(this.transform.position.x),
            yOffset,
            Mathf.RoundToInt(this.transform.position.z)
        );

        this.transform.position = position;
    }

    void Update()
    {
        SnapToGrid();
    }
}
