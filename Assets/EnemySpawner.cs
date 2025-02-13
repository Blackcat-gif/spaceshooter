using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject enemiesContainer;

    [SerializeField] private float secondsToSpawn = 2.9f;
    [SerializeField] private bool isPlayerDead = false;

    private void start()
    {
        StartCorutine(SpawnEnemy());
    }
   IEnumerator SpawnEnemy()
    {
        while(isPlayerDead == false)
        {
            float randomX = Random.Range(-8,8);
            Vector3 postionToSpawn = new Vector3(randomX, 7.5f, 0);

            Instantiate(enemyPrefab. postionToSpawn, Quaternion.identity, enemiesContainer.transform);
            yield return new WaitForSeconds(secondsToSpawn);
        }
    }
    public void IsPlayerDead(bool playerStatus)
    {
        isPlayerDead = playerStatus;
    }
}
    
   
