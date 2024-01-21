using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    public GameObject flashlightDown;
    public GameObject flashlightUp;
    private Rigidbody2D mafiaVRB;
    public Animator mafiaVAnim;
    private Transform currentPoint;
    public float x;
    public float y = -2;
    
    // Start is called before the first frame update
    void Start()
    {
        mafiaVRB = GetComponent<Rigidbody2D>();
        mafiaVAnim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        flashlightUp.SetActive(false);
    }

    void Update()
    {
        Vector2 point  = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform)
        {
            mafiaVRB.velocity = new Vector2(x, y);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            Debug.Log("Point A reached");
            mafiaVRB.velocity = new Vector2(x = 0, y = -2);
            currentPoint = pointB.transform;
            mafiaVAnim.Play("walkDown");
            flashlightDown.SetActive(true);
            flashlightUp.SetActive(false);
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            Debug.Log("Point B reached");
            mafiaVRB.velocity = new Vector2(x = 0, y = 2);
            currentPoint = pointA.transform;
            mafiaVAnim.Play("walkUp");
            flashlightDown.SetActive(false);
            flashlightUp.SetActive(true);
        }
    }
}