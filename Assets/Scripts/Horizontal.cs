using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : MonoBehaviour
{
    public GameObject pointC;
    public GameObject pointD;
    public GameObject flashlightRight;
    public GameObject flashlightLeft;
    private Rigidbody2D mafiaHRB;
    public Animator mafiaHAnim;
    private Transform currentPoint;
    public float x = -2;
    public float y;
    
    // Start is called before the first frame update
    void Start()
    {
        mafiaHRB = GetComponent<Rigidbody2D>();
        mafiaHAnim = GetComponent<Animator>();
        currentPoint = pointD.transform;
        mafiaHAnim.SetBool("changeDirection", true);
        flashlightLeft.SetActive(false);
    }

    void Update()
    {
        Vector2 point  = currentPoint.position - transform.position;
        if(currentPoint == pointD.transform)
        {
            mafiaHRB.velocity = new Vector2(x, y);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointC.transform)
        {
            Debug.Log("Point C reached");
            mafiaHRB.velocity = new Vector2(x = 2, y = 0);
            currentPoint = pointD.transform;
            mafiaHAnim.Play("walkRight");
            flashlightRight.SetActive(true);
            flashlightLeft.SetActive(false);    
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointD.transform)
        {
            Debug.Log("Point D reached");
            mafiaHRB.velocity = new Vector2(x = -2, y = 0);
            mafiaHAnim.SetBool("changeDirection", true);
            currentPoint = pointC.transform;
            mafiaHAnim.Play("walkLeft");
            flashlightRight.SetActive(false);
            flashlightLeft.SetActive(true);
        }
    }
}