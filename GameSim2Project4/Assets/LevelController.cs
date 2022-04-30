using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int currentLevel;
    public bool levelTransition;
    public GameObject enemyManager;

    public void LoadLevel()
    {
        if (levelTransition)
        {
            EnemyController enemyManagerObject = enemyManager.GetComponent<EnemyController>();
            enemyManagerObject.LoadLevelEnemies();
            levelTransition = false;
        }
    }
}
