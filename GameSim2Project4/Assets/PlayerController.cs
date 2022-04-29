using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Animator animator;

    public GameObject fsmController;
    //public bool playerIsRunning;
    //public bool playerIsWalking;
    
    
   public void PlayerRunning()
   {
       animator.SetBool("IsRunning", true);
       animator.SetBool("IsWalking", false);
       //playerIsRunning = true;
   }

   public void PlayerWalking()
   {
       animator.SetBool("IsRunning", false);
       animator.SetBool("IsWalking", true);
   }

   public void PlayerIdle()
   {
       animator.SetBool("IsRunning", false);
       animator.SetBool("IsWalking", false);
   }
   //
   // public void PlayerWalking()
   // {
   //     animator.SetBool("IsWalking", true);
   // }
   // public void StopWalking()
   // {
   //     animator.SetBool("IsWalking", false);
   //     player
   // }
   //
   // public void StopRunning()
   // {
   //     animator.SetBool("IsRunning", false);
   //     playerIsRunning = false;
   // }
    public void MovePlayer()
    {
        FSMController.PlayerState playerState = fsmController.GetComponent<FSMController>().playerState;

        switch (playerState)
        {
            case FSMController.PlayerState.Running:
            {
                PlayerRunning();
            }
                break;

            case FSMController.PlayerState.Walking:
            {
                PlayerWalking();
            }
                break;

            case FSMController.PlayerState.Idle:
            {
                PlayerIdle();
            }
                break;
        }
        
        
        // if (player == FSMController.PlayerState.Running)
        // {
        //     PlayerRunning();
        //     Debug.Log("WorkingAnim");
        // }
        // else if (player == FSMController.PlayerState.Walking)
        // {
        //     PlayerWalking();
        // }
        // else
        // {
        //   //  PlayerIdle();
        // }

        // switch (PlayerState.)
        // {
        //     
        // }
        // if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        // {
        //     PlayerRunning();
        // }
        //
        // if (playerIsRunning)
        // {
        //     if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.LeftShift) ||
        //         Input.GetKeyUp(KeyCode.RightShift))
        //     {
        //         StopRunning();
        //     }
        // }
        // if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        // {
        //   PlayerWalking();
        // }
        
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
