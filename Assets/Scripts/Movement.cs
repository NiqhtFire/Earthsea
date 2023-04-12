using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    
    public Controller controller;
    public float horizontalMove = 0f;
    bool verticalMove = false;
    bool crouch = false;
    public Interaction interaction;
   

    public float speed = 40f;
    public float jumpSpeed = 5f;

    public string[] interactionTypes =new string[] {"Ogion", "Ship", "library", "book", "Jasper"};
    //public ParticleSystem dustparticle;
     
    SpriteRenderer srenderer; 
    void Start()
    {
        
        //partvalue = dustparticle.velocityOverLifeTime.x;
        srenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        
        if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.W)){
            verticalMove = true;
        }
        if (Input.GetKey(KeyCode.S)){
           // crouch = true;
        }
    
        if(horizontalMove == -40) {
            srenderer.flipX = true;
            Debug.Log("asd");
        }else if(horizontalMove == 40){
            srenderer.flipX = false;
        }
        
    }

    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, verticalMove);
        verticalMove = false;
        crouch = false;
    }


    


    void OnTriggerStay2D(Collider2D obj)
    {
        foreach (string elem in interactionTypes) { 
                if(obj.gameObject.tag == elem) {
                interaction.interactHandler(true, obj.gameObject.tag);
            }
        }

        if(obj.tag == "Shadow"|| obj.tag == "Spike" ){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          
        }

        if(obj.tag == "Door"){
           
        interaction.eUI.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E)){
                 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        }
       
    }
} 
  

    void OnTriggerExit2D(Collider2D obj)
    {
        foreach (string elem in interactionTypes) { 
            if(obj.gameObject.tag == elem) {
            interaction.interactHandler(false, null);
         }
        }
    }

}