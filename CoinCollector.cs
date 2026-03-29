using UnityEngine;

public class CoinCollector : MonoBehaviour {
    public int coinCount = 0;  // To keep track of the number of coins collected
    public GameObject coinPrefab; // Prefab for the coin object

    private void Start() {
        SpawnCoins();
    }

    private void Update() {
        // Optional: Logic can be added here for further interaction
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Coin")) {
            CollectCoin(other.gameObject);
        }
    }

    private void CollectCoin(GameObject coin) {
        coinCount++;
        Destroy(coin); // Removes the coin from the scene
        Debug.Log("Coins collected: " + coinCount);
    }

    private void SpawnCoins() {
        for (int i = 0; i < 10; i++) { // Spawns 10 coins
            Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), 1f, Random.Range(-5f, 5f));
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }
}