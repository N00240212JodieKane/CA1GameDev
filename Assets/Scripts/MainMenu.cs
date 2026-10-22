using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Tooltip("The name of the scene to load when starting the game.")]
    public string gameSceneName = "Level_1";
    
    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
