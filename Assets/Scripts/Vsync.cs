using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vsync : MonoBehaviour
{

    void Start()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 90;
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
