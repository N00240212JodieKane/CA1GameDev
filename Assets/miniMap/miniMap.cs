using UnityEngine;

public class miniMap : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float heightAbovePlayer;
    public Transform player;

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 newPosition = player.position + Vector3.up * heightAbovePlayer;
        transform.position = newPosition;
    }
    
}
