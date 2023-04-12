using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textFlip : MonoBehaviour
{
    public GameObject player;
    Transform pos;
    void Start()
    {
        pos = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Transform>().position = new Vector3(pos.position.x, pos.position.y + 0.3f, pos.position.z); 
    }
}
