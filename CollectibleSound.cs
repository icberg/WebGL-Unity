using UnityEngine;

public class CollectibleSound : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Ensure the object interacting has the "Player" tag
        {
            audioSource.Play();
            // Optionally, add code to disable or destroy the collectible
            gameObject.SetActive(false); // or Destroy(gameObject);
        }
    }
}

