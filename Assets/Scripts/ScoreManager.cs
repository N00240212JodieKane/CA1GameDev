using UnityEngine; 
using TMPro; 
 
public class ScoreManager : MonoBehaviour 
{ 
    TextMeshProUGUI coinText; 
    int coins; 
 
    void Awake()
{
    coinText = GetComponent<TextMeshProUGUI>();
}
 
    void Start() 
    { 
        UpdateText(); 
    } 
 
    public void IncreaseScore() 
    { 
        coins++; 
        UpdateText(); 
    } 
 
    void UpdateText() 
    { 
        coinText.text = "Coin: " + coins; 
    } 
} 

