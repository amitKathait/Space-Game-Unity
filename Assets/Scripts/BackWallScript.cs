using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWallScript : MonoBehaviour
{
    public GameControlScript control;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger entered");
        control.PlayerDied();
    }
}
