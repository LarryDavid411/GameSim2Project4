using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public GameObject mainCamera;

    public Vector3 cameraOffset;


    public void MoveCamera()
    {
        mainCamera.transform.position = player.transform.position + cameraOffset;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
