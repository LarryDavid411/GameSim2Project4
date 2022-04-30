using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] gameObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadLevelEnemies()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy_1");
    }
    
    public void MoveEnemies()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[0].GetComponent<EnemyAI_1>().UpdateEnemy();
        }
    }
}
