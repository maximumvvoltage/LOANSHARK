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

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        ProcessInputs();
        Animate();
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed;
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
}