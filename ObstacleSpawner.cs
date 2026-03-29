using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles; // Array to hold different obstacles
    public float spawnInterval = 2f; // Time interval between spawns
    public float spawnRangeX = 4f; // Range for spawning obstacles on X-axis
    public float spawnHeight = 1f; // Height at which obstacles will spawn

    void Start()
    {
        StartCoroutine(SpawnObstacles()); // Start the obstacle spawning coroutine
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            SpawnObstacle(); // Call the spawn function
            yield return new WaitForSeconds(spawnInterval); // Wait for the specified interval
        }
    }

    void SpawnObstacle()
    {
        // Calculate a random spawn position
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnHeight, transform.position.z);
        // Randomly select an obstacle from the array
        GameObject obstacle = obstacles[Random.Range(0, obstacles.Length)];
        // Instantiate the obstacle at the spawn position
        Instantiate(obstacle, spawnPosition, Quaternion.identity);
    }
}