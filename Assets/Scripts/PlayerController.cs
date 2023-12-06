using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float speed = 4.0f;
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"),
       Input.GetAxis("Vertical")) * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}