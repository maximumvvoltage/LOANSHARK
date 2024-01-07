using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideBox : MonoBehaviour
{
    public float moveSpeed;
    public Transform player;

    public float followPlayerRange;
    private bool inRange;
    public float sensingRange;

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) <= followPlayerRange && Vector2.Distance(transform.position, player.position) > sensingRange)
        {
            inRange = true;
            Debug.Log("inRange = TRUE --------");
        }
        else
        {
            inRange = false;           
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, followPlayerRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, sensingRange);
    }
}