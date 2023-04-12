using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

public class dialogue : MonoBehaviour
{
    
    public TextMeshProUGUI textdisplay;
    public string[] sentences;
    [SerializeField] private int index;
    public float typingSpeed;
    public bool textactive;
    public GameObject continueButton;
    public bool changetime;
    public GameObject rojdtext;
    public Movement move;
    public Scene scene;
    public questText qtext;

    public GameObject magic;
    public GameObject buyu;
    void Awake(){
        scene = SceneManager.GetActiveScene();
    }
    void Start()
    {
        StartCoroutine(Type());
       
    }


    private void Update() {
        Debug.Log(scene.name);
       
        if(textdisplay.text == sentences[index]){
            continueButton.SetActive(true);
        }

        if(index < sentences.Length - 1){
            textactive = true;
             Time.timeScale = 0;
          
        }

        if(index == sentences.Length -1){
            StartCoroutine(change());
        }


        if(Input.GetMouseButton(0)){
            typingSpeed = 0.01f;
            
            
        }else{
            typingSpeed = 0.06f;
            
        }

    }
 
    IEnumerator change(){
        yield return new WaitForSecondsRealtime(0.2f);
        changetime = true;
    }

    IEnumerator Type(){

        foreach(char letter in sentences[index].ToCharArray()){
            textdisplay.text += letter;
            yield return new WaitForSecondsRealtime(typingSpeed);

        }
    }
    public void NextSentence(){
        continueButton.SetActive(false);
        if(index < sentences.Length -1){
            index++;
            textdisplay.text = "";
          
            StartCoroutine(Type());
        } else {
            textdisplay.text = "";
            continueButton.SetActive(false);
            if(scene.name == "Opening"){
                Debug.Log("kek");
                SceneManager.LoadScene("SampleScene");
            }
            Time.timeScale = 1;
            rojdtext.SetActive(false);
            if(scene.name == "Roke"){
                buyu.SetActive(true);  
                magic.SetActive(true);
            }
            
            
            move.interactionTypes = move.interactionTypes.Where(s => s != "Ogion").ToArray();
            //qtext.quests = qtext.quests.Where(s => s != "Ogionla Konuş").ToArray();
            qtext.updateQuests(true);
     
            
            Debug.Log("asd");
           
            this.gameObject.SetActive(false);

         
            
    
        }

        if(changetime == true){
            Time.timeScale = 1;
           
        }
       
    }

}