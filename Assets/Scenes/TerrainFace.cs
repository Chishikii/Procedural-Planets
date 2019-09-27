using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainFace
{
    Mesh mesh;
    int resolution;
    // Meshnormal
    Vector3 localUp;
    // other 2 vectors
    Vector3 axisA;
    Vector3 axisB;

    public TerrainFace(Mesh mesh, int resolution, Vector3 localUp)
    {
        this.mesh = mesh;
        this.resolution = resolution;
        this.localUp = localUp;

        axisA = new Vector3(localUp.y, localUp.x, localUp.z);
        axisB = Vector3.Cross(localUp, axisA);
    }

    public void ConstructMesh()
    {
        //All the vertices for the polys 
        Vector3[] vertices = new Vector3[resolution * resolution];
        //vertices for the triangles
        int[] triangles = new int[(resolution - 1) * (resolution - 1) * 2 * 3];

    }
}
