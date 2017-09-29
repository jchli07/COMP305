using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;
    private Transform camTrans;

    // Use this for initialization
    void Start()
    {
        camTrans = this.transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (player.position.x < -3.5)
        {
            camTrans.position = new Vector3(player.position.x, player.position.y, -5);
        }

        else if (player.position.x > -3.5 && player.position.x < 4.9)
        {
            camTrans.position = new Vector3(0.94f, 0.32f, -5);
        }

        else if (player.position.x > 4.9)
        {
            camTrans.position = new Vector3(player.position.x, player.position.y, -5);

            if (player.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                Camera.main.orthographicSize -= 0.01f;
            }

            if (player.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
            {
                Camera.main.orthographicSize += 0.01f;
            }
        }


    }
}
