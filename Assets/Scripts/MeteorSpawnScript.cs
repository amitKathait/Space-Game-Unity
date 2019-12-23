using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnScript : MonoBehaviour
{

    float spawnTreshold = 100;
    float spawnDecrement = .1f;

    public GameObject meteor;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Random.Range(0, spawnTreshold));
        if (Random.Range(0, spawnTreshold) <= 1)
        {
            // Create meteor randomly palced
            Vector3 pos = transform.position;
            Instantiate(meteor, new Vector3(pos.x + Random.Range(-6, 6), pos.y, pos.z), Quaternion.identity);

            spawnTreshold -= spawnDecrement;
            //Debug.Log(spawnTreshold);
            if (spawnTreshold < 2)
            {
                spawnTreshold = 2;
            }
        }
    }
}
