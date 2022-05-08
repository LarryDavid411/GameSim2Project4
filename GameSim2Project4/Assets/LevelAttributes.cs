using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAttributes : MonoBehaviour
{
    public float levelHealth;
    public int levelNumber;
    public int levelType;
    public GameObject[] doorKnobsType1;
    public GameObject[] enemyLights;
    public GameObject levelManager;
    public GameObject doorManager;

    public float doorSpeed;
    public float doorDisplacement;
    public bool doorsOpen;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public bool levelComplete;
    public Vector3 doorMover;
    
   // public LevelController levelManager;

   public void AdvanceLevel()
   {
      // doorDisplacement = 0;
      doorManager.GetComponent<DoorController>().openDoors = true;
        levelComplete = true;
        
        levelManager.GetComponent<LevelController>().currentLevel++;
   }
    public void OpenDoors()
    {
        Debug.Log("openDoors");
        if (doorDisplacement <= 5.1)
        {
           // Vector3 doorMover = Vector3.zero;
            doorMover.x = doorSpeed * Time.deltaTime;
            doorDisplacement += doorMover.x;
            leftDoor.transform.position -= doorMover;
            rightDoor.transform.position += doorMover;
        }
        else
        {
            doorsOpen = true;
            // doorDisplacement = 0;
        }
    }

    
    public void LoadDoorKnobsForCurrentLevel()
    {
        doorKnobsType1 = GameObject.FindGameObjectsWithTag("DoorKnobs1");
    }

    public void LevelUpdate()
    {
        if (!levelComplete)
        {
            if (levelType == 1)
            {
                float currentScore = 6 / levelHealth;
                int setNumber = Mathf.RoundToInt(levelHealth) * 2;
                if (levelHealth <= 0)
                {
                    levelHealth = 0;
                }

                // if (setNumber >= 6)
                // {
                //     AdvanceLevel();
                // }
        
                if (setNumber > 0 && setNumber <= 6)
                {
                    for (int i = 0; i < doorKnobsType1.Length; i++)
                    {
                        if (doorKnobsType1[i].GetComponent<DoorKnobController>().knobSequence <= setNumber)
                        {
                            doorKnobsType1[i].GetComponent<DoorKnobController>().knobState = DoorKnobController.KnobState.Green;
                        }
                        else
                        {
                            doorKnobsType1[i].GetComponent<DoorKnobController>().knobState = DoorKnobController.KnobState.Red;
                        }
           
                        doorKnobsType1[i].GetComponent<DoorKnobController>().DoorKnobUpdate();
                    }
                }
                if (levelHealth >= 3)
                {
                    //Debug.Log("AdvaceLevel");
                    AdvanceLevel();
                    for (int i = 0; i < enemyLights.Length; i++)
                    {
                        enemyLights[i].GetComponent<EnemyAI_1>().enemyState = EnemyAI_1.EnemyState.Off;
                    }
                    
                }

                // if (setNumber > 6)
                // {
                //
                //     //  levelManager.GetComponent<LevelController>().currentLevel++;
                // }
            }
        }
        else
        {
            Debug.Log("boo");
            OpenDoors();
        }
        Debug.Log("level1");
    }
}
