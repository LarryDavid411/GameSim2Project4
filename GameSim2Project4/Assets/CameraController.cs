using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public GameObject mainCamera;
    public GameObject playerCameraSeparator; 

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
        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(uiPoint);
        
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            crosshair.transform.position = raycastHit.point;
        }
        
        //playerCameraSeparator.transform.LookAt(); 
    }

    public void MoveCamera()
    {
        // Camera Position
        // mainCamera.transform.position = player.transform.position + cameraOffset;

        // Camera Rotation
        _yaw += speedHorizontal * Input.GetAxis("Mouse X") * Time.deltaTime;
        _pitch -= speedVertical * Input.GetAxis("Mouse Y") * Time.deltaTime;

        // Set Crosshair
        SetCrosshair();
        
        playerRotation = new Vector3(_pitch, _yaw, 0.0f);
        
        if (playerRotation.x > 35)
        {
            playerRotation.x = 35;
            _pitch = playerRotation.x;
        }
        if (playerRotation.x < -35)
        {
            playerRotation.x = -35;
            _pitch = playerRotation.x;
        }
        //Debug.Log(playerRotation);
        mainCamera.transform.eulerAngles = playerRotation;
       // Debug.Log(mainCamera.transform.eulerAngles);
       // Debug.ClearDeveloperConsole(); 
        // Set Player Camera Separator
       // playerCameraSeparator.transform.LookAt(Vector3.right, crosshair.transform.position); 
        
    }
}
