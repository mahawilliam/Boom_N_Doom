using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Sprite[] cannonSprites;
    public float startWait;
    public float cannonWait;
    public GameObject cannon1;
    public GameObject bombRed;
    void Start()
    {
        StartCoroutine (SpawnWaves ());   
    }

    IEnumerator SpawnWaves ()
    {
        
        while (true) {
            for (int i = 0; i < cannonSprites.Length; i++) {
                cannon1.GetComponent<SpriteRenderer>().sprite = cannonSprites[i];
                yield return new WaitForSeconds (cannonWait);
                if (i == cannonSprites.Length - 1) {
                    ShootBomb();
                }
                
            }
        }
    }

    void ShootBomb() {
        GameObject bombClone = Instantiate(bombRed, cannon1.transform.position, Quaternion.identity);
        bombClone.GetComponent<Rigidbody2D>().velocity = transform.right * Random.Range(-10f, 10f);
    }
}
