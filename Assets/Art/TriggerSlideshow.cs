using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerSlideshow : MonoBehaviour
{
    public GameObject slideshowPanel;
    public Sprite[] slides;
    public Image slideImage;
    public float slideDuration = 3f;

    public AudioSource audioSource;
    public float fadeSpeed = 1f;

    private int currentSlide = 0;
    private bool hasStarted = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasStarted)
        {
            hasStarted = true;

            if (AmbientAudio.instance != null)
                AmbientAudio.instance.StopAmbient();

            slideshowPanel.SetActive(true); // show UI
            StartCoroutine(StartSlideshow());
        }
    }

    IEnumerator StartSlideshow()
    {
        audioSource.volume = 0f;
        audioSource.Play();

        StartCoroutine(FadeInAudio());
        yield return StartCoroutine(PlaySlideshow());
        yield return StartCoroutine(FadeOutAudio());
    }

    IEnumerator PlaySlideshow()
    {
        while (currentSlide < slides.Length)
        {
            slideImage.sprite = slides[currentSlide];
            yield return new WaitForSeconds(slideDuration);
            currentSlide++;
        }
    }

    IEnumerator FadeInAudio()
    {
        while (audioSource.volume < 1f)
        {
            audioSource.volume += Time.deltaTime * fadeSpeed;
            yield return null;
        }
    }

    IEnumerator FadeOutAudio()
    {
        while (audioSource.volume > 0f)
        {
            audioSource.volume -= Time.deltaTime * fadeSpeed;
            yield return null;
        }
    }
}