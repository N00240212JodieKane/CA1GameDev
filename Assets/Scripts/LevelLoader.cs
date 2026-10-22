using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [Tooltip("The name of the scene to load when starting the game.")]
    [SerializeField] private string nextLevelSceneName = "Level_2";

    // Update is called once per frame
    public void LoadNextLevel()
    {
        Time.timeScale = 1f; // Reset time scale to normal before loading the next level
        SceneManager.LoadScene(nextLevelSceneName);
    }
}
