using UnityEngine;
using System.Collections;



public class MainController : MonoBehaviour
{
    

    public float moveSpeed;
    public float jumpForce;
    public float mainCatchTime = -1; //For Hurting

    public GameObject failedLevelCanvas;
    public GameObject completeLevelCanvas;
    public GameObject SpeedCanvas;
    public GameObject tapCanvas;

    public GameObject Booster;
    public GameObject BoosterD;

    public GameObject Booster2;
    public GameObject BoosterD2;

    public GameObject Booster3;
    public GameObject BoosterD3;

    public GameObject tBox;


    
    public string leveltag;

    public AudioSource LevelMusic;
    



    private Rigidbody2D myRigidBody;
    //Affecting the Rigidbody, do want to able with this with other code "Private"


    public bool grounded; //ForCheckbox

    public LayerMask whatIsGround;

    private Collider2D myCollider;

    private Animator myAnim;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>(); //Search Rigidbody2D from Guard in Srart()

        myCollider = GetComponent<Collider2D>(); //Search any Collider2D from Guard in Srart()

        myAnim = GetComponent<Animator>(); //Search any Animatior from Guard in Srart()

        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();﻿

    }

    // Update is called once per frame
    void Update()
    {

        
        
        myAnim.SetBool("Grounded" , grounded);   

      

        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);  //For finding Ground

        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);   //For initializing X and Y values (Up/Down) , 2nd for just jump

        //myAnim.SetBool("Grounded", true);

        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (grounded)
            {
                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce); //For Jumping
                //myAnim.SetBool("Grounded", false);
              
            }
            
            myAnim.SetBool("Grounded", false);
            SMScript.PlaySound("jump");
            tapCanvas.SetActive(false);
            
        }
        
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy") || collision.collider.gameObject.layer == LayerMask.NameToLayer("Guard"))
        {
            moveSpeed = 0;
            jumpForce = 0;
            mainCatchTime = Time.time;
            myAnim.SetBool("Death", true);
            LoadFailedLevel();
            SMScript.PlaySound("levelfail");
            LevelMusic.Stop();
            
            

        }
       if (collision.collider.gameObject.layer == LayerMask.NameToLayer("LevelStop") )
        {
            moveSpeed = 0;
            jumpForce = 0;
            mainCatchTime = Time.time;
            myAnim.SetBool("Stop", true);
            completeLevel();
            LoadLevel();
            SMScript.PlaySound("levelcomplete");
            LevelMusic.Stop();
                   

       }
       if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Speed"))
       {
           moveSpeed = 15;
          mainCatchTime = Time.time;
           SpeedPlayer();
           Destroy(Booster);
          


       }
       if (collision.collider.gameObject.layer == LayerMask.NameToLayer("SpeedD"))
       {
           moveSpeed = 10;
           mainCatchTime = Time.time;
           SpeedDown();
           Destroy(BoosterD);



       }

       if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Speed2"))
       {
           moveSpeed = 15;
           mainCatchTime = Time.time;
           SpeedPlayer();
           Destroy(Booster2);



       }
       if (collision.collider.gameObject.layer == LayerMask.NameToLayer("SpeedD2"))
       {
           moveSpeed = 10;
           mainCatchTime = Time.time;
           SpeedDown();
           Destroy(BoosterD2);



       }
       if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Speed3"))
       {
           moveSpeed = 15;
           mainCatchTime = Time.time;
           SpeedPlayer();
           Destroy(Booster3);



       }
       if (collision.collider.gameObject.layer == LayerMask.NameToLayer("SpeedD3"))
       {
           moveSpeed = 10;
           mainCatchTime = Time.time;
           SpeedDown();
           Destroy(BoosterD3);



       }
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("tObj"))
        {
            tapCanvas.SetActive(true);
            Destroy(tBox);
        }

        
        
    }

        public void LoadLevel()
        {
        PlayerPrefs.SetInt(leveltag, 1);

        
        }
   
     public void LoadFailedLevel(){
         StartCoroutine("failedWait");
     
     }
     IEnumerator failedWait()
     {
         yield return new WaitForSeconds(1.5f);
         failedLevelCanvas.SetActive(true);
     }
     public void completeLevel()
     {
         StartCoroutine("completeWait");

     }
     IEnumerator completeWait()
     {
         yield return new WaitForSeconds(1f);
         completeLevelCanvas.SetActive(true);
     }
     public void SpeedPlayer()
     {
         SpeedCanvas.SetActive(true);
     }
     public void SpeedDown()
     {
         SpeedCanvas.SetActive(false);
     }

   

    
        
     

}


        


  





