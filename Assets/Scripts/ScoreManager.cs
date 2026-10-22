using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private int coinsRequired = 4;

    [Header("Level Complete")]
    [SerializeField] private GameObject levelCompletePanel;

    private int coins = 0;
    private bool levelComplete = false;

    private void Start()
    {
        Time.timeScale = 1f;

        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(false);
        }

        UpdateText();
    }

    
public void IncreaseScore()
{
    if (levelComplete)
        return;

    coins++;

    Debug.Log("COIN COUNT: " + coins + " / " + coinsRequired);

    UpdateText();

    if (coins >= coinsRequired)
    {
        ShowLevelComplete();
    }
}


    private void UpdateText()
    {
        if (coinText == null)
        {
            Debug.LogError("Coin Text is not assigned!");
            return;
        }

        coinText.text = "Coins: " + coins + " / " + coinsRequired;
    }

    private void ShowLevelComplete()
    {
        levelComplete = true;

        Debug.Log("LEVEL COMPLETE!");

        if (levelCompletePanel != null)
        {
            levelCompletePanel.SetActive(true);
        }

        Time.timeScale = 0f;

        var input =
            FindFirstObjectByType<StarterAssets.StarterAssetsInputs>();

        if (input != null)
        {
            input.cursorLocked = false;
            input.cursorInputForLook = false;
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    
public void RestartLevel()
{
    Time.timeScale = 1f;

    SceneManager.LoadScene(
        SceneManager.GetActiveScene().buildIndex
    );
}

}
