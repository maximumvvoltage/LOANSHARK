using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
//    public Transform[] ttrolPoints;
    public int currentWaypointIndex = 0;
    private float speed = 3f;

    public GameObject pointD;
    public GameObject pointC;
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
        currentPoint = pointD.transform;
        mafiaAnim.SetBool("changeDirection", true);
        //flashlightUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point  = currentPoint.position - transform.position;
        if(currentPoint == pointD.transform)
        {
            mafiaRB.velocity = new Vector2(x, y);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointC.transform)
        {
            Debug.Log("Point C reached");
            mafiaRB.velocity = new Vector2(x = 0, y = 2);
            currentPoint = pointD.transform;
            mafiaAnim.Play("walkUp");
            flashlightDown.SetActive(true);
            flashlightUp.SetActive(false);
     
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointD.transform)
        {
            Debug.Log("Point D reached");
            mafiaRB.velocity = new Vector2(x = 0, y = -2);
            currentPoint = pointC.transform;
            mafiaAnim.Play("walkDown");
            flashlightUp.SetActive(true);
            flashlightDown.SetActive(false);
        }
        // if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointC.transform)
        // {
        //     Debug.Log("Point C reached");
        //     mafiaRB.velocity = new Vector2(x = -2, y = 0);
        //     currentPoint = pointD.transform;
        // }
        // if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointD.transform)
        // {
        //     Debug.Log("Point D reached");
        //     mafiaRB.velocity = new Vector2(x = -2, y = 0);
        //     currentPoint = pointE.transform;
        // }
        // if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointE.transform)
        // {
        //     Debug.Log("Point E reached");
        //     mafiaRB.velocity = new Vector2(x = -2, y = 0);
        //     currentPoint = pointF.transform;           
        // }
        // if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointF.transform)
        // {
        //     Debug.Log("Point F reached");
        //     mafiaRB.velocity = new Vector2(x = -2, y = 0);
        //     currentPoint = pointG.transform;   
        // }                            
        // if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointG.transform)
        // {
        //     Debug.Log("Point F reached");
        //     mafiaRB.velocity = new Vector2(x = -2, y = 0);
        //     currentPoint = pointC.transform;   
        // }
        // if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointH.transform)
        // {
        //     Debug.Log("Point H reached");
        //     mafiaRB.velocity = new Vector2(x = -2, y = 0);
        //     currentPoint = pointI.transform;   
        // }
        // if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointH.transform)
        // {
        //     Debug.Log("Point I reached");
        //     mafiaRB.velocity = new Vector2(x = -2, y = 0);
        //     currentPoint = pointJ.transform;   
        // }
    }
}