using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaders_SpawnManager : MonoBehaviour
{
    // Referencing GameObjects
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    [SerializeField] private GameObject enemy3;

    public bool spawning = true;

    private GameObject[] Enemies;

    void Start()
    {

        Enemies = new GameObject[3];
        Enemies[0] = enemy1;
        Enemies[1] = enemy2;
        Enemies[2] = enemy3;

            StartCoroutine(EmemyDelay());
    }

    void SpawnEnemy()
    {
        int randomNum = Random.Range(0, 3); // Random Number to pick a GameObject for the array
        int randomNum2 = Random.Range(3, 6); // Random Number to generate the number of enemies
        float randomNum3 = Random.Range(-10, 5.35f); // Random Number to pick a X-axis location

        for(int i = 1; i < randomNum2; i++)
        {
            Instantiate(Enemies[randomNum], new Vector3(randomNum3 + i, 5.95f + i, 0), Quaternion.identity);
        }
    }
    IEnumerator EmemyDelay()
    {
        while(spawning)
        {
            int randomNum = Random.Range(2,5);
            yield return new WaitForSeconds(randomNum);
            SpawnEnemy();
        }
    }
}
