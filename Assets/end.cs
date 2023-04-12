using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject fadein;
    public GameObject endText;
    void Start()
    {
        
    }
    void Awake(){
        StartCoroutine(ending());

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ending(){
        yield return new WaitForSeconds(8);

        fadein.SetActive(true);
        yield return new WaitForSeconds(1);
        endText.SetActive(true);
    }
}
