
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private AudioClip collectSound;
    [SerializeField] private float volume = 1f;
    [SerializeField] private ScoreManager scoreManager;

    private bool collected = false;

    private void Awake()
    {
        if (scoreManager == null)
        {
            scoreManager = FindFirstObjectByType<ScoreManager>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (collected)
            return;

        if (!other.CompareTag("Player"))
            return;

        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager not found!");
            return;
        }

        // Lock this coin before awarding points.
        
if (collected)
    return;

collected = true;

Debug.Log("COIN AWARD: " + gameObject.name);

scoreManager.IncreaseScore();


        if (collectSound != null)
        {
            AudioSource.PlayClipAtPoint(
                collectSound,
                transform.position,
                volume
            );
        }

        gameObject.SetActive(false);
    }
}
