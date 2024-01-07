using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canHide;
    public bool isHiding;
    public bool canMove;
    public bool crouched;

    public float movementSpeed = 5f;

    public GameObject player;
    public Rigidbody2D rb;
    public Animator animator;
    
    Vector2 movement;

    private void Start()
    {
        canMove = true;
        crouched = false;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (crouched == false & Input.GetKeyDown(KeyCode.LeftShift))
        {     
            if (crouched == false)
            {
                crouched = true;
                movementSpeed = 2f;
            }            
        }

        if (crouched = true & Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (crouched == true)
            {
                crouched = false;
                movementSpeed = 5f;
            }            
            Debug.Log("Player is no longer hiding");
        }

        if (canHide == true & Input.GetKeyDown(KeyCode.F))
        {     
            if (isHiding == false)
            {
                isHiding = true;
                Debug.Log("Player is hiding");
                canMove = false;

                player.GetComponent<Renderer>().enabled = false;
            }            
            
        }

        if (isHiding = true & Input.GetKeyUp(KeyCode.F))
        {
            if (isHiding == true)
            {
                isHiding = false;
                canMove = true;
                player.GetComponent<Renderer>().enabled = true;
            }            
            Debug.Log("Player is no longer hiding");
        }

    }
    void FixedUpdate()
    {
        if (canMove == true)
        {
            rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        }        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Hiding Spot")
        {
            canHide = true;
            Debug.Log("Player can hide");
        }
    }    

    private void OnTriggerExit2D(Collider2D collex)
    {
        canHide = false;
        Debug.Log("Player can not hide");
    }

}