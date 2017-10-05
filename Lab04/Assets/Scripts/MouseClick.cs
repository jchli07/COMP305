using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

    public GameObject Bomb;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            print(Input.mousePosition);
            Vector3 p = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
            print(p);
            print(p.x);
            print(p.y);

            Instantiate(Bomb, new Vector3(p.x, p.y, 0.0f), Quaternion.identity);
        }
    }
}
