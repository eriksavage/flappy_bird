using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPipeSet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipeSet;
    public float yOffset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float highestSpawnPoint = transform.position.y + yOffset;
        float lowestSpawnPoint = transform.position.y - yOffset;
        var spawnPosition = new Vector3(gameObject.transform.position.x, Random.Range(lowestSpawnPoint, highestSpawnPoint), 0);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(pipeSet, spawnPosition, gameObject.transform.rotation);
            Debug.Log($"PipeSet Spawned At: {spawnPosition}");
        }
    }
}
