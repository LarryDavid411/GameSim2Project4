using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player;

    public GameObject cameraController;

    public GameObject fsmController;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FSMController fsmControllerObject = fsmController.GetComponent<FSMController>();
        fsmControllerObject.ModifyPlayerSate();
            
        PlayerController playerObject = player.GetComponent<PlayerController>();
        playerObject.MovePlayer();

        CameraController cameraControllerObject = cameraController.GetComponent<CameraController>();
        cameraControllerObject.MoveCamera();

    }
}
