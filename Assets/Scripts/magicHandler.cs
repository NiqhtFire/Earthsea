using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class magicHandler : MonoBehaviour
{
    public bool T, Y, U;
    public GameObject mageEffect;
    public GameObject shadow;
    public GameObject shadowtext;
    public GameObject closing;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)){
            T = true;
            StartCoroutine(Delay(T));
            
        }
         if(Input.GetKeyDown(KeyCode.Y)){
            Y = true;
            StartCoroutine(Delay(Y));
            
        }
         if(Input.GetKeyDown(KeyCode.U)){
            U = true;
            StartCoroutine(Delay(U));
            
        }

        if(T && Y && U ){
            // execute magic 
            mageEffect.SetActive(true);
            shadow.SetActive(true);
            shadowtext.SetActive(true);

            StartCoroutine(Close());


        }
    }
    IEnumerator Delay(bool a){
        yield return new WaitForSeconds(0.3f);
        a = false;
    }

    IEnumerator Close(){
        yield return new WaitForSeconds(7);
        closing.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene("Level1");


    }
    
}
