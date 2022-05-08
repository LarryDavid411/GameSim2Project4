using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool openDoors;
    public int currentLevel;
    public GameObject[] leftDoors;
    public Vector3 doorMover;
    public float doorSpeed;
    public float doorDisplacement;

    public GameObject[] rightDoors;
    // Start is called before the first frame update
    void Start()
    {
        leftDoors = GameObject.FindGameObjectsWithTag("DoorsLeft");
        rightDoors = GameObject.FindGameObjectsWithTag("DoorsRight");
    }

    public void OpenDoors()
    {
        if (openDoors)
        {
            Debug.Log("doorsOpen");
            if (doorDisplacement <= 5.1)
            {
                doorMover.x = doorSpeed * Time.deltaTime;
                leftDoors[currentLevel - 2].transform.position -= doorMover;
                rightDoors[currentLevel - 2].transform.position += doorMover;
            }
            else
            {
                openDoors = false;
            }
        }
    }
    
   
}
