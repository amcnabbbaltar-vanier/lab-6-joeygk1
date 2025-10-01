using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Add this namespace

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int totalScore = 0;
    public int score = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        totalScore += amount;
        Debug.Log("Score: " + totalScore);
    }

    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex + 1;

        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            Debug.Log("No more scenes to load.");
        }
    }
}

