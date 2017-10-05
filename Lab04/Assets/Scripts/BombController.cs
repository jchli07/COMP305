using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{

    public GameObject explosion;
    public float timeToDestroy = 1.0f;
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    { 
    }
}