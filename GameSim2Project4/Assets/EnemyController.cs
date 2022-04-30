using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] enemyObjectsType1;
    public GameObject levelManager;
    public GameObject player;
    
    
    public void LoadLevelEnemies()
    {
        enemyObjectsType1 = GameObject.FindGameObjectsWithTag("Enemy_1");
    }
    
    public void MoveEnemies()
    {
        for (int i = 0; i < enemyObjectsType1.Length; i++)
        {
            if (enemyObjectsType1[i].GetComponent<EnemyAI_1>().enemyLevel ==
                levelManager.GetComponent<LevelController>().currentLevel)
            {
                enemyObjectsType1[i].GetComponent<EnemyAI_1>().UpdateEnemy();
                enemyObjectsType1[i].transform.Find("Cone").GetComponent<LightCollision>().PlaceLightCone();
            }
        }
    }
}
