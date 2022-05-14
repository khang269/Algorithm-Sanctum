using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Grid3D {
    private int xSize;
    private int ySize;
    private int zSize;

    private Vector3 corner;

    public Grid3D(int x, int y, int z)
    {
        xSize = x;
        ySize = y;
        zSize = z;

        corner = new Vector3
            (
                -(float)xSize / 2f,
                -(float)ySize / 2f,
                -(float)zSize / 2f
            );
    }

    public int[] getIndex(Vector3 vector)
    {
        int xIndex = (int)(vector.x - corner.x);
        int yIndex = (int)(vector.y - corner.y);
        int zIndex = (int)(vector.z - corner.z);
        return new int[] { xIndex, ySize, zIndex };
    }  

    public Vector3 getPosition(int[] index)
    {
        if(index.Length < 3)
        {
            throw new ArgumentException("Index missing");
        }

        return new Vector3
            (
                (float)index[0] + 0.5f + corner.x,
                (float)index[1] + 0.5f + corner.y,
                (float)index[2] + 0.5f + corner.z
            );
    }
}
