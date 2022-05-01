using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAttributes : MonoBehaviour
{
    public float levelHealth;
    public int levelNumber;
    public GameObject[] doorKnobsType1;
    
   // public LevelController levelManager;

    public void LoadDoorKnobsForCurrentLevel()
    {
        doorKnobsType1 = GameObject.FindGameObjectsWithTag("DoorKnobs1");
    }

    public void LevelUpdate()
    {
        //Debug.Log(doorKnobsType1.Length);
        float currentScore = 6 / levelHealth;
        int setNumber = Mathf.RoundToInt(levelHealth); 
        //Debug.Log(currentScore);
        // if ((levelHealth - 1) * (2 - levelHealth) >= 0)
        // {
        //     setNumber = 1;
        //     Debug.Log("type");
        // }
        //
        Debug.Log("length" + doorKnobsType1.Length);
        Debug.Log(setNumber);
        

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
}
