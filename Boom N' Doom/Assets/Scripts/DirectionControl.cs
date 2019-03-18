using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionControl : MonoBehaviour
{
    public Sprite DeathKnight_Back;
    public Sprite DeathKnight_Front;
    public Sprite DeathKnight_Left;
    public Sprite DeathKnight_Right;

    void Start() {
        this.GetComponent<SpriteRenderer>().sprite = DeathKnight_Front;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") < 0) {
            this.GetComponent<SpriteRenderer>().sprite = DeathKnight_Front;
        }
        if (Input.GetAxis("Vertical") > 0) {
            this.GetComponent<SpriteRenderer>().sprite = DeathKnight_Back;
        }
        if (Input.GetAxis("Horizontal") > 0) {
            this.GetComponent<SpriteRenderer>().sprite = DeathKnight_Right;
        }
        if (Input.GetAxis("Horizontal") < 0) {
            this.GetComponent<SpriteRenderer>().sprite = DeathKnight_Left   ;
        }
    }
}
