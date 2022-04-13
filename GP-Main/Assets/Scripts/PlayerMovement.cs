using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f; 
    public float gravity = -9.81f;
    public float jumpHeight = 2f;
    private Animator  anim;
    Vector3 velocity;

    public bool isGrounded;
    public Transform groundCheck;

    public float groundDistance = 0.4f;

    public LayerMask groundMask;


    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Character Body").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if(x != 0 || z != 0){
            // anim.Rebind();
            MovePlayer();
        }else {
            anim.SetBool("isWalking", false);
        }


        if(Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            
            //anim.SetBool("isWalking", false);
            anim.SetBool("isJumping", true);
        }

        if(!Input.GetButtonDown("Jump")){
            anim.SetBool("isJumping", false);
        }
        velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
            // anim.SetBool("isJumping", false);
        GameObject.FindGameObjectWithTag("Character Body").transform.position = new Vector3(GameObject.FindGameObjectWithTag("Player").transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y - 2.16f, GameObject.FindGameObjectWithTag("Player").transform.position.z);
    }

    void MovePlayer(){
    float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        anim.SetBool("isWalking", true);
        controller.Move(move * speed * Time.deltaTime);  
        
    }
    void JumpPlayer(){
    float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        anim.SetBool("isWalking", true);
        controller.Move(move * speed * Time.deltaTime);  
    }
}
