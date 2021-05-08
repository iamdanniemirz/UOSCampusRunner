using UnityEngine;
using System.Collections;

public class AIHurdles : MonoBehaviour {
	
	public Transform leftPoint;
	
	
	public float moveSpeed;
    public float jumpForce = 30 ;
	private bool canMove;
	
	private Rigidbody2D myRigidbody;
	
	public bool movingLeft;
	
	private Animator myAnim;

	// Use this for initialization
	void Start () {
	myRigidbody = GetComponent<Rigidbody2D>();
	myAnim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
			
			
			if(  movingLeft && transform.position.x > leftPoint.position.x )
			{
				movingLeft = true;
			}
			
			if(movingLeft){
				myRigidbody.velocity = new Vector3 ( -moveSpeed , myRigidbody.velocity.y , 0f);
			}
		
		
		
	
	}
	void OnCollisionEnter2D (Collision2D collision){

        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Player") || collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
		{
			moveSpeed = 0;
			
			myAnim.SetBool("Stop" , true );
		}
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Speed") || collision.collider.gameObject.layer == LayerMask.NameToLayer("SpeedD") || collision.collider.gameObject.layer == LayerMask.NameToLayer("Speed2") || collision.collider.gameObject.layer == LayerMask.NameToLayer("SpeedD2") || collision.collider.gameObject.layer == LayerMask.NameToLayer("Speed3") || collision.collider.gameObject.layer == LayerMask.NameToLayer("SpeedD3"))
        {
            
            
            if (movingLeft)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            }
        
          
           

           
        }
	
		
	
}
}
