using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class questText : MonoBehaviour
{
    public string[] quests =new string[] {"Ogionla Konuş", "Roke'a git"};
    public string[] rokequests = new string[] {"Kütüphaneye Git", "Kitap Seç"};
    public TextMeshProUGUI questT;
    public int questnum = 0;

    int loopcount;
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "SampleScene"){
            questnum = 0;
            questT.text = quests[questnum];
        }
        else if(SceneManager.GetActiveScene().name == "Roke"){
            questnum = 0;
            questT.text = rokequests[questnum];
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateQuests(bool resetloopc){
        Debug.Log("çalışıyo bura");
        questnum++;
        Debug.Log("questnum:" + questnum);
        if(SceneManager.GetActiveScene().name == "SampleScene"){
            
            questT.text = quests[questnum];
        }
        if(SceneManager.GetActiveScene().name == "Roke"){
        
            questT.text  = rokequests[questnum];
        }else{
            questT.text = quests[questnum];
        }
        if(resetloopc) {
            loopcount = 0;
        }
        //questT.text = "";
        foreach (string elem in quests){
            if(loopcount == 0){
              //  questT.text = "- " + elem;
            }
            else{
              //  questT.text += "\n" + "- " + elem;
            }
            loopcount++;
        }
    }
}
