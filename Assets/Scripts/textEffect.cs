using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textEffect : MonoBehaviour
{
    public TextMeshProUGUI texta;
    public Color colora;
    public float decrease = 0.02f;
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
            colora.a -= decrease;
            texta.color = colora;
            yield return new WaitForSeconds(0.02f);
        }
        Destroy(gameObject); 
    }
}   