using UnityEngine; 
using TMPro; 
 
public class ScoreManager : MonoBehaviour 
{ 
    TextMeshProUGUI coinText; 
    int coins; 
 
    void Awake() 
    { 
        // ScoreManager sits on the same object as the text, 
        // so GetComponent finds it here. 
        	 
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
        coinText.text = "Coins: " + coins; 
    } 
} 

