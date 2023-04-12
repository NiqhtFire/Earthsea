using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeoutEffect : MonoBehaviour
{
    public float fadeDuration = 1.0f; // duration of the fade-out effect in seconds
    public UnityEngine.UI.Image panelImage; // reference to the panel's Image component

    private float startTime; // time when the fade-out effect starts
 
    void Awake () {


        // remember the start time
        startTime = Time.time;
        // set the alpha value of the panel's color to 1 (fully opaque)
        Color color = panelImage.color;
        color.a = 1.0f;
        panelImage.color = color;
        // start the coroutine that performs the fade-out effect
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut() {
       Debug.Log("workin");
        float elapsedTime = Time.time - startTime;
        
        float percentage = elapsedTime / fadeDuration;
      
        Color color = panelImage.color;
        color.a = 1.0f - percentage;
        panelImage.color = color;
    
        yield return null;
      
        if (percentage < 1.0f) {
            StartCoroutine(FadeOut());
        }else{
            Destroy(this.gameObject);
        }
    
    }
}
