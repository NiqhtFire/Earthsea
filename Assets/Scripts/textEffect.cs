using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textEffect : MonoBehaviour
{
    public TextMeshProUGUI texta;
    public Color colora;

    void Start()
    {
        colora = texta.color;
        colora.a = 1f; 
        texta.color = colora; 
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        while (colora.a > 0) {
            colora.a -= 0.02f;
            texta.color = colora;
            yield return new WaitForSeconds(0.02f);
        }
        Destroy(gameObject); 
    }
}   