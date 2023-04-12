using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Linq;
public class Interaction : MonoBehaviour
{   
    public GameObject eUI;
    public GameObject dialoguemanager1;
    public GameObject rojdtext;
    public bool checkCollide = true; 
    public TextMeshProUGUI questT;
    public questText q;   
    public GameObject librarytext; 

    public GameObject selection;
    public Movement move;
    public GameObject book;
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

    public void closebook(){

        book.SetActive(false);
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
            }else if(interactType == "library"){
               
                librarytext.SetActive(true);
                q.updateQuests(true);
            }else if(interactType == "book"){
                eUI.SetActive(true);
                if(inputChecker()){
                    move.interactionTypes = move.interactionTypes.Where(s => s != "book").ToArray();
                    Debug.Log("open magic tab");
                    book.SetActive(true);
                }
        
            }
            if(interactType == "Jasper"){

                eUI.SetActive(true);
                if(inputChecker()){
                    move.interactionTypes = move.interactionTypes.Where(s => s != "Jasper").ToArray();
                    dialoguemanager1.SetActive(true);
                    rojdtext.SetActive(true);
                    
                }
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

                     selection.SetActive(true);
                   
                     
                }
              
                
            }
        }else if(!isColliding){
            eUI.SetActive(false);
            checkCollide = true;
        }

        
            
    }
    public void LoadRoke(){
            SceneManager.LoadScene("roke");
        }
    public void EndGame(){
            SceneManager.LoadScene("Ogion");
        }
    
}
        
    

