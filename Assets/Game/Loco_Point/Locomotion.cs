using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour {

    private Vector3 point;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        point = PointMove.Instance.hitPoint;

        point.y = 0f;

        transform.position = Vector3.Lerp(transform.position, point, Time.deltaTime/2);

	}
}
