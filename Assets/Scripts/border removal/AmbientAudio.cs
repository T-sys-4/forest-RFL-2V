using UnityEngine;

public class AmbientAudio : MonoBehaviour
{
    public static AmbientAudio instance;
    private AudioSource audioSource;

    void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void StopAmbient()
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }

        Destroy(gameObject); // deletes the ambient sound object
    }
}