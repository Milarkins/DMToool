using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSnap : MonoBehaviour
{
    public float xOffset, yOffset;
    private Grid g;
    void Start()
    {
        g = Grid.FindObjectOfType<Grid>();
    }

    void Update()
    {
        Vector3Int cp = g.LocalToCell(transform.localPosition);
        transform.localPosition = g.GetCellCenterLocal(cp) + new Vector3(xOffset, yOffset, 0);
    }
}
