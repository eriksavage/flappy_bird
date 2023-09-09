using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdState : MonoBehaviour
{
    // private bool falling = true;
    public Rigidbody2D birdBody;
    public Sprite birdFlap;
    public Sprite birdFall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (birdBody.velocity.y > 0)
        {
            GetComponent<SpriteRenderer>().sprite = birdFlap;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = birdFall;
        }
    }
}
