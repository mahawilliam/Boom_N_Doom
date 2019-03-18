using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{

    public float lifetime;
    public ParticleSystem explosion;
    private bool collideWithPlayer;
   
    void Start ()
    {
        Destroy (gameObject, lifetime);
        // collideWithPlayer = false;
    }

    void OnDestroy() {
        Explode();    
        //CameraShake();
    }

    void Explode() {
        Instantiate( explosion, transform.position, Quaternion.identity);
        if(collideWithPlayer) {
            Debug.Log("aduh meledak");
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            collideWithPlayer = true;
            Debug.Log("hi");
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            collideWithPlayer = false;
            Debug.Log("bye");
        }
    }
    /* 
    public Transform camTransform;
    public float shakeAmount = 0.7f;
    public float shakeDuration = 0f;
	public float decreaseFactor = 1.0f;
    Vector2 originalPos;
    void CameraShake() {
        while (shakeDuration > 0) {
            originalPos = camTransform.localPosition;
            camTransform.localPosition = originalPos + Random.insideUnitCircle * shakeAmount;
			
			shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        camTransform.localPosition = originalPos;
    }
    */
}