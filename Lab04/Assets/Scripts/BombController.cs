using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public float explosionRadius = 50.0f;
    public float explosionForce = 1.0f;
    private RaycastHit2D[] hits;
    public GameObject explosion;
    public float timeToDestroy = 1.0f;
  
    void Awake()
    {
        StartCoroutine(explode());
    }

    // Update is called once per frame
    void Update()
    { 

    }

    IEnumerator explode()
    {
        yield return new WaitForSeconds(timeToDestroy);

        hits = Physics2D.CircleCastAll(this.transform.position, explosionRadius, Vector2.zero);
        foreach (RaycastHit2D h in hits)
        {
            if (h.transform.gameObject.tag == "Crate")
                h.rigidbody.AddForce((h.transform.position - this.transform.position) * explosionForce, ForceMode2D.Impulse);
        }

        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}