using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rune : MonoBehaviour
{
    [SerializeField] private Color activationColor;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Image runeImage;
    [SerializeField] private float colorTransitionDuration = 0.3f;

    // Start is called before the first frame update

    public void RuneClicked() 
    {
        StartCoroutine(ActivateRune());
    }
    private IEnumerator ActivateRune()
    {
        audioSource.Play();

        yield return LerpToColor(Color.white, activationColor);

        while(audioSource.isPlaying)
        {
            yield return new WaitForEndOfFrame();
        }

        yield return LerpToColor(activationColor, Color.white);
    }

    private IEnumerator LerpToColor(Color start, Color end)
    {
        float elapsedTime = 0;
        float startTime = Time.time;
        while (elapsedTime < colorTransitionDuration)
        {
            runeImage.color = Color.Lerp(start, end, elapsedTime / colorTransitionDuration);
            elapsedTime = Time.time - startTime;
            yield return null;
        }
         

    }
}
