using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgorundScript : MonoBehaviour {

    public float speed = -2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        if (transform.position.y <= -15)
        {
            transform.Translate(0f, 30f, 0f);
        }
	}
}
