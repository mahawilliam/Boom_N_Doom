using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    //private bool isCarrying;
    //private Transform currentItem;
    //public Transform carryLocation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //isCarrying = false;
        //currentItem = null;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;
        
    }
    /* 
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            if (currentItem != null) {

                currentItem.parent = null;
                currentItem.position = transform.GetComponent<SpriteRenderer>().bounds.max;
                currentItem = null;
            }
        }
    }
    

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            if (Input.GetButton("Fire1") && !isCarrying) {
                currentItem = other.transform;
                currentItem.position = carryLocation.position;
                currentItem.parent = transform;
            }
        }
    }
    */
}
