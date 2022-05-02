using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int currentLevel;
    
    public bool levelTransition;
    public bool gameStartIndexLevels;
    public bool loadLevelDoorKnobs;
    public GameObject enemyManager;

    public GameObject levelManager;
    

    public GameObject[] enemyInLevel;
    // _knobStates;
    public GameObject[] allLevels;
    
    private void IndexAllLevelObjects()
    {
        enemyInLevel = GameObject.FindGameObjectsWithTag("Enemy_1");
        allLevels = GameObject.FindGameObjectsWithTag("Level");
    }

    // public void LevelUpdate()
    // {
    //     
    //     //for (int i = 0; i < doorKn)
    // }

    public void LoadLevel()
    {
        for (int i = 0; i < enemyInLevel.Length; i++)
        {
            if (enemyInLevel[i].GetComponent<EnemyAI_1>().enemyLevel == currentLevel)
            {
                enemyInLevel[i].SetActive(true);
            }
            else
            {
                enemyInLevel[i].SetActive(false);
            }
        }
        if (gameStartIndexLevels)
        {
            IndexAllLevelObjects();
            gameStartIndexLevels = false;
        }
        if (levelTransition)
        {
            EnemyController enemyManagerObject = enemyManager.GetComponent<EnemyController>();
            enemyManagerObject.LoadLevelEnemies();
            levelTransition = false;
        }

        if (loadLevelDoorKnobs)
        {
            LevelAttributes loadLevelDoorKnobsObject = allLevels[currentLevel - 1].GetComponent<LevelAttributes>();
            loadLevelDoorKnobsObject.LoadDoorKnobsForCurrentLevel();
           // DoorKnobController doorKnobObject = 
            loadLevelDoorKnobs = false;

        }
    }
}
