using UnityEngine;
using System.Collections;

public class GuardControl : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpForce = 17;
	public float  mainCatchTime = -1; 
	
    

	private Rigidbody2D myRigidBody;
	//Affecting the Rigidbody, do want to able with this with other code "Private"


	public bool grounded; //ForCheckbox
	
	public LayerMask whatIsGround;

	private Collider2D myCollider;

	private Animator myAnim;

	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> (); //Search Rigidbody2D from Guard in Srart()

		myCollider = GetComponent<Collider2D> (); //Search any Collider2D from Guard in Srart()

		myAnim = GetComponent<Animator> (); //Search any Animatior from Guard in Srart()
	
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.IsTouchingLayers ( myCollider, whatIsGround );  //For finding Ground
	
		myRigidBody.velocity = new Vector2 ( moveSpeed , myRigidBody.velocity.y );   //For initializing X and Y values (Up/Down) , 2nd for just jump

		if(Input.GetKeyDown(KeyCode.Alpha0))
			//(|| Input.GetTouch(0).phase == TouchPhase.Began) For Touch 
			if (grounded) {
				
				myRigidBody.velocity = new Vector2 ( myRigidBody.velocity.x , jumpForce ); //For Jumping
				
		
			
		}

	myAnim.SetBool ("GuardGround" , grounded);
	
	}
	void OnCollisionEnter2D (Collision2D collision){
		if(collision.collider.gameObject.layer == LayerMask.NameToLayer ("Player")){
			moveSpeed = 0;
			mainCatchTime = Time.time;
			myAnim.SetBool("Catch" , true);
		}
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy") || collision.collider.gameObject.layer == LayerMask.NameToLayer("Students"))
        {
            if (grounded)
            {

                myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce); //For Jump

            }
        }
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("GuardStop"))
        {
            moveSpeed = 0;
            mainCatchTime = Time.time;
            myAnim.SetBool("GuardStop", true);
        }


	}
	
	
	
	
	
	
}