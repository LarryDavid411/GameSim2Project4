using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightCollision : MonoBehaviour
{
    public GameObject spotLight;
    public GameObject enemy;
    public GameObject player;
    
   // public Collision player;
    private void Update()
    {
        //Debug.Log(gameObject.GetComponent<Light>().range);
        
        
       // OnCollisionStay(player);
    }

    public void PlaceLightCone()
    {
        Vector3 range = spotLight.transform.position;
        range.y = spotLight.GetComponent<Light>().range / 2;
        gameObject.GetComponent<Transform>().localScale = new Vector3(range.y, range.y, range.y);
        gameObject.transform.localPosition = new Vector3(0, range.y, 0);
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (enemy.GetComponent<EnemyAI_1>().enemyState == EnemyAI_1.EnemyState.Green)
            {
                other.GetComponent<HealthController>().health += Time.deltaTime;
            }
            else if (enemy.GetComponent<EnemyAI_1>().enemyState == EnemyAI_1.EnemyState.Red)
            {
                other.GetComponent<HealthController>().health -= Time.deltaTime;
            }
            
        }
    }

    // public void Test()
    // {
    //     
    //     Debug.Log("Ding Ding!");
    // }
    // private void OnTriggerEnter(Collision collisionInfo)
    // {
    //     
    // }
}
