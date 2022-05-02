using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public GameObject mainCamera;

    public Vector3 cameraOffset;
    public bool setCamera;

    public float speedHorizontal;
    public float speedVertical;
    private float _yaw;
    private float _pitch;

    public Vector3 playerRotation;
    public void SetCamera()
    {
          
    }

    public void MoveCamera()
    {
        // Camera Position
        mainCamera.transform.position = player.transform.position + cameraOffset;

        // Camera Rotation
        _yaw += speedHorizontal * Input.GetAxis("Mouse X") * Time.deltaTime;
        _pitch -= speedVertical * Input.GetAxis("Mouse Y") * Time.deltaTime;

        playerRotation = new Vector3(_pitch, _yaw, 0.0f);
        
        mainCamera.transform.eulerAngles = playerRotation;
    }
}
