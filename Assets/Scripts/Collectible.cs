
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private AudioClip collectSound;
    [SerializeField] private float volume = 1f;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] GameObject collectEffect;

    private bool collected = false;

    private void Awake()
    {
        if (scoreManager == null)
        {
            scoreManager = FindAnyObjectByType<ScoreManager>();
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

        if (collectEffect != null)
        {
            Instantiate(collectEffect, transform.position, Quaternion.identity);
        }

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
