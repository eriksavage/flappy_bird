using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPipeSet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipeSet;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(pipeSet, gameObject.transform);
        }
    }
}
