using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public bool playerRunning;
    

   public void PlayerRunning()
   {
       animator.SetBool("IsRunning", true);
   }

   public void StopRunning()
   {
       animator.SetBool("IsRunning", false);
   }
    public void MovePlayer()
    {
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)))
        {
            PlayerRunning();
        }

        if (playerRunning)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.LeftShift) ||
                Input.GetKeyUp(KeyCode.RightShift))
            {
                StopRunning();
            }
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
           // StopRunning();
        }
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
