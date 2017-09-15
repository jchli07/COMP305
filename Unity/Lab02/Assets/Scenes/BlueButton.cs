using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour {

    public Sprite blueS;
    public GameObject person;
    SpriteRenderer rend;

	// Use this for initialization
	void Start () {

        rend = person.GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        rend.sprite = blueS;
    }
}
