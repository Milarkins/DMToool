using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSnap : MonoBehaviour
{
    private Grid g;
    void Start()
    {
        g = Grid.FindObjectOfType<Grid>();
    }

    void Update()
    {
        Vector3Int cp = g.LocalToCell(transform.localPosition);
        transform.localPosition = g.GetCellCenterLocal(cp);
    }
}
