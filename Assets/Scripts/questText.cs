using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class questText : MonoBehaviour
{
    public string[] quests =new string[] {"Ogionla Konuş", "Roke'a git"};
    public TextMeshProUGUI questT;
    public int questnum = 0;

    int loopcount;
    void Start()
    {
        questT.text = quests[questnum];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateQuests(bool resetloopc){
        questnum++;
        Debug.Log("questnum:" + questnum);
        questT.text = quests[questnum];
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
