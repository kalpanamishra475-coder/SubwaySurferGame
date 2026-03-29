using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int score;
    private string gameState;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        gameState = "Menu"; // Initial Game State
        score = 0; // Initial Score
    }

    public void ChangeGameState(string newState)
    {
        gameState = newState;
        Debug.Log("Game State Changed to: " + gameState);
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }

    public int GetScore()
    {
        return score;
    }

    public string GetGameState()
    {
        return gameState;
    }
}