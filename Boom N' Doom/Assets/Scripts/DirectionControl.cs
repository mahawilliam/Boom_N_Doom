using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionControl : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") < 0) {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<PickUp>().enabled = true;
        }
        if (Input.GetAxis("Vertical") > 0) {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<PickUp>().enabled = false;
        }
        if (Input.GetAxis("Horizontal") != 0) {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<PickUp>().enabled = false;
        }
    }
}
