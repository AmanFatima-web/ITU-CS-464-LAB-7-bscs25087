
using UnityEngine;
using System.Collections;

public class PanelFade : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float duration = 0.5f;

    public void FadeIn()
    {
        gameObject.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(Fade(0f, 1f));
    }

    public void FadeOut()
    {
        StopAllCoroutines();
        StartCoroutine(Fade(1f, 0f, true));
    }

    IEnumerator Fade(float start, float end, bool hideAfter = false)
    {
        float time = 0f;
        canvasGroup.alpha = start;

        while (time < duration)
        {
            time += Time.deltaTime;

            float progress = time / duration;
            progress = Mathf.SmoothStep(0f, 1f, progress);

            canvasGroup.alpha = Mathf.Lerp(start, end, progress);

            yield return null;
        }

        canvasGroup.alpha = end;

        if (hideAfter)
        {
            gameObject.SetActive(false);
        }
    }
}
