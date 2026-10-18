using UnityEngine; 
 
public class CoinRotator : MonoBehaviour 
{ 
    [Header("Rotation")]
    [SerializeField] bool rotate = true;
    [SerializeField] float degreesPerSecond = 90f; 

    [Header("Bobbing")]
    [SerializeField] bool bob = true;
    [SerializeField] float bobAmount = 0.015f;
    [SerializeField] float bobSpeed = 0.05f;

    Vector3 startingLocalPosition;

    void Start()
    {
        startingLocalPosition = transform.localPosition;
    }

    void Update() 
    { 
        if (rotate)
        {
            transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f, Space.World);
        }

        if (bob)
        {
            float bobOffset = (Mathf.Sin(Time.time * bobSpeed) + 1f) * 0.5f * bobAmount;
            transform.localPosition = startingLocalPosition + Vector3.up * bobOffset;
        }
    } 
} 
