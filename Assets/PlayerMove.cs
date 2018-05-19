using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charControl;
    public float walkSpeed;

	public Transform bulletSpawn;
	public GameObject bullet;
    
    public float jumpSpeed=1;
    public float gravity=1;
    Vector3 moveDirection;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();

		if(Input.GetButton("Fire1")){
			Instantiate(bullet,bulletSpawn.position,bulletSpawn.rotation);
		}
        
    }

    void MovePlayer()
    {
        if(charControl.isGrounded){
            float horiz = Input.GetAxis("Horizontal");
            float vert = Input.GetAxis("Vertical");

            moveDirection = new Vector3(horiz,0,vert);
            moveDirection = transform.TransformDirection(moveDirection);
            
            if(Input.GetButton("Jump")){
                moveDirection.y=jumpSpeed;
            }
        }
        

        moveDirection.y -= gravity * Time.deltaTime;
        

        
        charControl.SimpleMove(moveDirection*Time.deltaTime);

        

       
        

    }
}
