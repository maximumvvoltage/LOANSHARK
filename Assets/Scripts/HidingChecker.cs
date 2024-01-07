using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidingChecker : MonoBehaviour
{

    public bool playerIsHiding;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHiding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHiding == true)
        {
            //Debug.Log("Player is hidden");
        }
        else
        {
            //Debug.Log("Player is not hidden");
        }
    }   

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            playerIsHiding = true;
        }        
    }

    private void OnTriggerExit2D(Collider2D collex)
    {
        playerIsHiding = false;
    }
}
