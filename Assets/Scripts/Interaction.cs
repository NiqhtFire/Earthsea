using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Interaction : MonoBehaviour
{   
    public GameObject eUI;
    public GameObject dialoguemanager1;
    public GameObject rojdtext;
    public bool checkCollide = true; 
    public TextMeshProUGUI questT;
    public questText q;    
    void Start()
    {
    
    }
    
    void Awake()
    {
        checkCollide = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }


    bool inputChecker(){
        if(Input.GetKey(KeyCode.E)){
            
            return true;
           

        }else{
      
            return false;
        }


    }
    public void interactHandler(bool isColliding, string interactType) { 
        if(isColliding){
            if(q.questnum == 0 && interactType == "Ogion"){
                eUI.SetActive(true);
            }
            else if (q.questnum == 1 && interactType == "Ship"){
                eUI.SetActive(true);
            }
            
            //eUI.SetActive(true);  
            if(inputChecker()){
                
                eUI.SetActive(false);
            
                isColliding = false;

                if(interactType == "Ogion"){
                    eUI.SetActive(false);  
                    dialoguemanager1.SetActive(true);
                    rojdtext.SetActive(true);
                }

                if(interactType == "Ship" && questT.text == "Roke'a git"){
                    
                     eUI.SetActive(false);
                     SceneManager.LoadScene("roke");
                     
                }
              
                
            }
        }else if(!isColliding){
            eUI.SetActive(false);
            checkCollide = true;
        }
            
    }
    
}
        
    

