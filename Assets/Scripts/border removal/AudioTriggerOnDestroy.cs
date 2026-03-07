using UnityEngine;

public class AudioAndDestroyController : MonoBehaviour
{
    public GameObject introSlideshow; // object that will be destroyed
    public GameObject endCredits;     // object that will be enabled later
    public AudioSource audioSource;   // 2D audio source

    private bool audioPlayed = false;

    void Start()
    {
        if (audioSource != null)
        {
            audioSource.Stop(); // ensure it doesn't play at start
        }
    }

    void Update()
    {
        // Play audio when introSlideshow gets destroyed
        if (!audioPlayed && introSlideshow == null)
        {
            audioSource.Play();
            audioPlayed = true;
        }

        // Destroy this object when End Credits appear
        if (endCredits != null && endCredits.activeInHierarchy)
        {
            Destroy(gameObject);
        }
    }
}