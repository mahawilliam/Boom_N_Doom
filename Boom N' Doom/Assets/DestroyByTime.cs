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
    }

    void Explode() {
        Instantiate( explosion, transform.position, Quaternion.identity );
    }
}