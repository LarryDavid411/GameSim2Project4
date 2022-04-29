using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMController : MonoBehaviour
{

    public GameObject playerController;
    
    public enum PlayerState
    {
        Walking,
        Running,
        Idle
    }

    
    
    
    
    public PlayerState playerState;


    public void ModifyPlayerSate()
    {
        switch (playerState)
        {
            case PlayerState.Idle:
            {
                // if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
                // {
                //     playerState = PlayerState.Running;
                //     Debug.Log("Running");
                // }
                if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                {
                    playerState = PlayerState.Walking;
                    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                    {
                        playerState = PlayerState.Running;
                    }
                }
            }
                break;
            
            case PlayerState.Walking:
            {
                if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
                {
                    playerState = PlayerState.Idle;
                }

                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    playerState = PlayerState.Running;
                }
            }
                break;

            case PlayerState.Running:
            {
                if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.LeftShift) ||
                         Input.GetKeyUp(KeyCode.RightShift))
                {
                    playerState = PlayerState.Idle;
                }
            }
                break;
            
            
        }
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        playerState = PlayerState.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
