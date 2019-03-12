using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player" && GetComponent<Rigidbody2D>() != null) {
            
        }
        else if (other.gameObject.tag == "Tile"){
            Destroy(GetComponent<Rigidbody2D>());
        }
    }
}
