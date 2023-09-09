using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flap : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D birdRb;
    public float power;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            birdRb.velocity = new Vector2(0.0f, 1.0f * power);
        }
    }
}
