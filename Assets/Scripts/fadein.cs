using UnityEngine;
using System.Collections;

public class fadein : MonoBehaviour {

    public float fadeInTime = 1f; // The duration of the fade in effect
    public UnityEngine.UI.Image panelImage; 

    void Awake () {
        Color color = panelImage.color;
        color.a = 0f; 
        panelImage.color = color;
        StartCoroutine(FadeInPanel(color));
    }

    IEnumerator FadeInPanel (Color color) {
        float t = 0f; 

        while (t < fadeInTime) {
            t += Time.deltaTime; 
            float alpha = Mathf.Lerp(0f, 1f, t / fadeInTime);
            color.a = alpha;
            panelImage.color = color;
            yield return null; 
        }

        color.a = 1f; 
        panelImage.color = color;
    }
}
