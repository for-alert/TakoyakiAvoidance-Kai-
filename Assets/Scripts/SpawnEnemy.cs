using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Use this for initialization
    public GameObject enemyPrefab;

    private int tic;

    // Update is called once per frame
    void Update()
    {
        if (tic % 15 == 0)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = new Vector2(Random.Range(-6.5f, 6.5f), 6);
        }

        tic++;
    }
}