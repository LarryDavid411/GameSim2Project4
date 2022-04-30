using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int currentLevel;
    public bool levelTransition;
    public bool gameStartIndexLevels;
    public GameObject enemyManager;

    public GameObject[] levelObjects;


    private void IndexAllLevelObjects()
    {
        levelObjects = GameObject.FindGameObjectsWithTag("Enemy_1");
        
    }

    public void LoadLevel()
    {
        for (int i = 0; i < levelObjects.Length; i++)
        {
            if (levelObjects[i].GetComponent<EnemyAI_1>().enemyLevel == currentLevel)
            {
                levelObjects[i].SetActive(true);
            }
            else
            {
                levelObjects[i].SetActive(false);
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
    }
}
