using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
//    public Transform[] ttrolPoints;
    public int currentWaypointIndex = 0;
    private float speed = 3f;

    public GameObject pointA;
    public GameObject pointB;
    public GameObject flashlightDown;
    public GameObject flashlightUp;

    private Rigidbody2D mafiaRB;
    private Animator mafiaAnim;
    private Transform currentPoint;
    public float x = 2;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        mafiaRB = GetComponent<Rigidbody2D>();
        mafiaAnim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        mafiaAnim.SetBool("changeDirection", true);
        //flashlightUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point  = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform)
        {
            mafiaRB.velocity = new Vector2(x, y);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            Debug.Log("Point A reached");
            mafiaRB.velocity = new Vector2(x = 0, y = -2);
            currentPoint = pointB.transform;
            mafiaAnim.Play("walkDown");
            flashlightDown.SetActive(true);
            flashlightUp.SetActive(false);
     
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            mafiaRB.velocity = new Vector2(x = 0, y = 2);
            currentPoint = pointA.transform;
            mafiaAnim.Play("walkUp");
            flashlightUp.SetActive(true);
            flashlightDown.SetActive(false);
        }
    }
}