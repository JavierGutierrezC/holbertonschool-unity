using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // reference to our player controller
    public CharacterController player;  
    public float speed = 12f; 
    public float gravity = -9.81f;
    public float jumpH = 8f;
    public Transform camera;
    Vector3 velocity;
    private Vector3 move = Vector3.zero;
    private float alt;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
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
            }
        }
        else
        {
            move = new Vector3(Input.GetAxis("Horizontal"), move.y, Input.GetAxis("Vertical"));
            move = camera.right * move.x + camera.forward * move.z;
            Debug.Log("movcam " + move);
           
            
            move = transform.TransformDirection(move);
            
            move.x *= speed;
            move.z *= speed;
            //Debug.Log("y" + y);
            //Debug.Log("move.y" + move.y);
            
        }
        
        move.y += gravity * Time.deltaTime;

        player.Move(move * Time.deltaTime);
        
    }
}
