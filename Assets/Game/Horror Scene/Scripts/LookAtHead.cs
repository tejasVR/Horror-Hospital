using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtHead : MonoBehaviour {

    public GameObject cameraHead;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(cameraHead.transform.position);


    }
}
