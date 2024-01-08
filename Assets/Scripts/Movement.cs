using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector2 input;
    private Vector2 lastMoveDirection;
    public Rigidbody2D rb;    
    Animator myAnim;
    public GameObject player;

    public bool canHide;
    public bool isHiding;
    public bool canMove;
    public bool crouched;

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        crouched = false;
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        ProcessInputs();
        Animate();

        if (crouched == false & Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (crouched == false)
            {
                crouched = true;
                speed = 1f;
            }
        }

        if (crouched = true & Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (crouched == true)
            {
                crouched = false;
                speed = 3f;
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

    private void FixedUpdate()
    {
        if (canMove)
        {
            rb.velocity = input * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if ((moveX == 0 && moveY == 0 ) && (input.x != 0 || input.y != 0))
        {
            lastMoveDirection = input;
        }
    
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        
        input.Normalize();
    }    

    void Animate()
    {
        myAnim.SetFloat("MoveX", input.x);
        myAnim.SetFloat("MoveY", input.y);
        myAnim.SetFloat("MoveMagnitude", input.magnitude);
        myAnim.SetFloat("LastMoveX", lastMoveDirection.x);
        myAnim.SetFloat("LastMoveY", lastMoveDirection.y);
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