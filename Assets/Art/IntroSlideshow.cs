using UnityEngine;
using UnityEngine.UI;

public class IntroSlideshow : MonoBehaviour
{
    public Sprite[] slides;
    public Image slideImage;
    public float slideDuration = 3f;

    public AudioSource audioSource;
    public float fadeSpeed = 1f;

    private int currentSlide = 0;

    void Start()
    {
        audioSource.volume = 0f;
        audioSource.Play();

        StartCoroutine(FadeInAudio());
        StartCoroutine(PlaySlideshow());
    }

    System.Collections.IEnumerator PlaySlideshow()
    {
        while (currentSlide < slides.Length)
        {
            slideImage.sprite = slides[currentSlide];
            yield return new WaitForSeconds(slideDuration);
            currentSlide++;
        }

        yield return StartCoroutine(FadeOutAudio());
        Destroy(gameObject);
    }

    System.Collections.IEnumerator FadeInAudio()
    {
        while (audioSource.volume < 1f)
        {
            audioSource.volume += Time.deltaTime * fadeSpeed;
            yield return null;
        }
    }

    System.Collections.IEnumerator FadeOutAudio()
    {
        while (audioSource.volume > 0f)
        {
            audioSource.volume -= Time.deltaTime * fadeSpeed;
            yield return null;
        }
    }
}