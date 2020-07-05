using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // reference to our player controller
    public CharacterController player;  
    public float speed = 12f; 
    public float gravity = 18f;
    public float jumpH = 9f;
    public Transform camera;
    Vector3 velocity;
    private Vector3 move = Vector3.zero;
    private float alt;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGrounded)
        {      
        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = transform.TransformDirection(move);
        
        move = camera.right * move.x + camera.forward * move.z;
        move.y = 0f;
        move *= speed;
            
            if (Input.GetButtonDown("Jump"))
            {
                move.y = jumpH;
                anim.SetTrigger("Jump");
            }
        }
        else
        {
            float initj = move.y;
    
            move = new Vector3(Input.GetAxis("Horizontal"), move.y, Input.GetAxis("Vertical"));
            move = camera.right * move.x + camera.forward * move.z;
            
            
            move = transform.TransformDirection(move);
            move.y = initj;

            move.x *= speed;
            move.z *= speed;
            
        }
        
        move.y += gravity * Time.deltaTime;

        player.Move(move * Time.deltaTime);

        if (player.transform.position.y < -10)
        {
            transform.position = new Vector3(0, 20, 0);
        }
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            anim.SetBool("Run",true);
        }
        else
        {
            anim.SetBool("Run",false);   
        }
    }
}
