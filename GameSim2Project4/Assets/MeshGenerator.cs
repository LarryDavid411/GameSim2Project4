using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    public int xSize;
    public int zSize;

    private Mesh mesh;
    private Vector3[] _vertices;
    private int[] _triangles;

    private void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
    }

   

    private void CreateShape()
    {
        _vertices = new Vector3[(xSize + 1) * (zSize + 1)];
        {
            int i = 0;
            for (int z = 0; z < xSize + 1; z++)
            {
                for (int x = 0; x < zSize + 1; x++)
                {
                    float y = Mathf.PerlinNoise(x * 0.3f, z * 0.3f) * 2f;
                    _vertices[i] = new Vector3(x, y, z);
                    i++;
                }
            }
        };

        _triangles = new int[xSize * zSize * 6];

        int verts = 0;
        int tris = 0;

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                _triangles[tris + 0] = verts + 0;
                _triangles[tris + 1] = verts + xSize + 1;
                _triangles[tris + 2] = verts + 1;
                _triangles[tris + 3] = verts + 1;
                _triangles[tris + 4] = verts + xSize + 1;
                _triangles[tris + 5] = verts + xSize + 2;

                verts++;
                tris += 6;
            }
            verts++;
        }
    }

    private void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = _vertices;
        mesh.triangles = _triangles;
        mesh.RecalculateNormals();
    }
}
