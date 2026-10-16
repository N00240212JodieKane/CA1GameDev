using UnityEngine; 
 
public class CoinRotator : MonoBehaviour 
{ 
    [SerializeField] float degreesPerSecond = 90f; 
 
    void Update() 
    { 
        transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f, Space.World); 
    } 
} 
