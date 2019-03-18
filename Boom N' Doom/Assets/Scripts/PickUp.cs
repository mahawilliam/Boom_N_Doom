using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform carryLocation;
    public Transform dropLocationBack;
    public Transform dropLocationFront;
    public Transform dropLocationLeft;
    public Transform dropLocationRight;
    bool isCarrying;
    public enum SpriteOrientation
    {
        ORIENT_LEFT,
        ORIENT_UP,
        ORIENT_RIGHT,
        ORIENT_DOWN
    }
    public SpriteOrientation direction;
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
        if (Input.GetAxis("Vertical") < 0) {
            direction = SpriteOrientation.ORIENT_DOWN;
        }
        if (Input.GetAxis("Vertical") > 0) {
            direction = SpriteOrientation.ORIENT_UP;
        }
        if (Input.GetAxis("Horizontal") > 0) {
            direction = SpriteOrientation.ORIENT_RIGHT;
        }
        if (Input.GetAxis("Horizontal") < 0) {
            direction = SpriteOrientation.ORIENT_LEFT;
        }
        if (isCarrying) {
            if (Input.GetKeyDown("space")) {
                isCarrying = false;
                item = carryLocation.GetChild(0);
                switch (direction) {
                    case SpriteOrientation.ORIENT_DOWN:
                        item.position = dropLocationFront.position;
                        break;
                    case SpriteOrientation.ORIENT_UP:
                        item.position = dropLocationBack.position;
                        break;
                    case SpriteOrientation.ORIENT_RIGHT:
                        item.position = dropLocationRight.position;
                        break;
                    case SpriteOrientation.ORIENT_LEFT:
                        item.position = dropLocationLeft.position;
                        break;
                }
                item.parent = null;
                Debug.Log("Dropping Up Bomb");
            }
        }
        
    }
}
