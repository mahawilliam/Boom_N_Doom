using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
    public float lifetime;
    public ParticleSystem explosion;
   
    void Start ()
    {
        Destroy (gameObject, lifetime);
    }

    void OnDestroy() {
        Explode();    
        //CameraShake();
    }

    void Explode() {
        Instantiate( explosion, transform.position, Quaternion.identity );
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