// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemyPatrolOne : MonoBehaviour
// {
// //    public Transform[] ttrolPoints;
//     public int currentWaypointIndex = 0;
//     //private float speed = 3f;

//     [Header("Points")]
//     public GameObject pointA;
//     public GameObject pointB;
//     public GameObject pointC;
//     public GameObject pointD;
//     public GameObject pointE;
//     public GameObject pointF;
//     public GameObject pointG;
//     public GameObject pointH;
//     public GameObject pointI;
//     public GameObject pointJ;
//     public GameObject pointK;
    
//     [Header("GameObjects")]
//     public GameObject flashlightUp;
//     public GameObject flashlightDown;
//     public GameObject flashlightLeft;
//     public GameObject flashlightRight;

//     private Rigidbody2D mafiaRB;
//     private Animator mafiaAnim;
//     private Transform currentPoint;
//     public float x = 2;
//     public float y;

//     // Start is called before the first frame update
//     void Start()
//     {
//         mafiaRB = GetComponent<Rigidbody2D>();
//         mafiaAnim = GetComponent<Animator>();
//         currentPoint = pointB.transform;
//         mafiaAnim.SetBool("changeDirection", true);
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         Vector2 point  = currentPoint.position - transform.position;
//         if(currentPoint == pointB.transform)
//         {
//             mafiaRB.velocity = new Vector2(x, y);
//         }
        
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
//         {
//             mafiaRB.velocity = new Vector2(x = 0, y = 2);
//             currentPoint = pointB.transform;
//             mafiaAnim.Play("walkDown");
//             flashlightDown.SetActive(true);
     
//         }

//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
//         {
//             mafiaRB.velocity = new Vector2(x = 0, y = 2);
//             currentPoint = pointC.transform;
//             mafiaAnim.Play("walkUp");
//             //flashlightD(SetActive);
     
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointC.transform)
//         {
//             mafiaRB.velocity = new Vector2(x = 0, y = -2);
//             currentPoint = pointD.transform;
//             mafiaAnim.Play("walkDown");
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointD.transform)
//         {

//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointE.transform;
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointE.transform)
//         {
//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointF.transform;
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointF.transform)
//         {

//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointG.transform;           
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointG.transform)
//         {
//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointH.transform;   
//         }                            
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointH.transform)
//         {
//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointI.transform;   
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointI.transform)
//         {
//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointJ.transform;   
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointJ.transform)
//         {
//             Debug.Log("Point I reached");
//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointK.transform;   
//         }
//         if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointK.transform)
//         {
//             Debug.Log("Point I reached");
//             mafiaRB.velocity = new Vector2(x = -2, y = 0);
//             currentPoint = pointD.transform;   
//             mafiaAnim.Play("walkDown");
//         }
//     }
// }