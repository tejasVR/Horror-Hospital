using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigFollow : MonoBehaviour {

    public GameObject cameraFollow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.Lerp(transform.position, cameraFollow.transform.position, Time.deltaTime);

    }
}
