using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    public GameObject player;
    Transform trans;
    Transform thistrans;
    void Start()
    {
        trans = player.GetComponent<Transform>();
        thistrans =  this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        thistrans.position = new Vector3(trans.position.x, trans.position.y + 1f, thistrans.position.z);
    }
}
