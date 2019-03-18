using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform carryLocation;
    public Transform dropLocation;
    bool isCarrying;
    private Transform item;
    void Start() {
        isCarrying = false;
    }
    
    void OnCollisionStay2D(Collision2D other)
    {
        if (!isCarrying && other.gameObject.tag == "Bomb") {
            Debug.Log("Colliding with Bomb");
            if (Input.GetButtonDown("Pickup1")) {
                other.transform.position = carryLocation.position;
                other.transform.parent = GameObject.Find("CarryLocation").transform;
                isCarrying = true;
                Debug.Log("Picking Up Bomb");
            }
        }
    }
    
    void Update() {
        if (isCarrying) {
            if (Input.GetKeyDown("space")) {
                isCarrying = false;
                item = carryLocation.GetChild(0);
                item.position = dropLocation.position;
                item.parent = null;
                Debug.Log("Dropping Up Bomb");
            }
        }
        
    }
}
