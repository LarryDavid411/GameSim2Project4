using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public GameObject mainCamera;

    public Vector3 cameraOffset;
    public GameObject centerOfUI;
    public bool setCamera;
    public GameObject crosshair;

    public float speedHorizontal;
    public float speedVertical;
    private float _yaw;
    private float _pitch;

    public Vector3 playerRotation;
    public void SetCrosshair()
    {
        Vector3 uiPoint = centerOfUI.transform.position;
        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            crosshair.transform.position = raycastHit.point;
        }
    }

    public void MoveCamera()
    {
        // Camera Position
        mainCamera.transform.position = player.transform.position + cameraOffset;

        // Camera Rotation
        _yaw += speedHorizontal * Input.GetAxis("Mouse X") * Time.deltaTime;
        _pitch -= speedVertical * Input.GetAxis("Mouse Y") * Time.deltaTime;

        // Set Crosshair
        SetCrosshair();
        
        playerRotation = new Vector3(_pitch, _yaw, 0.0f);
        
        mainCamera.transform.eulerAngles = playerRotation;
    }
}
