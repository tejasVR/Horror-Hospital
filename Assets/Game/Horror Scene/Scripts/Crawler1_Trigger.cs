using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler1_Trigger : MonoBehaviour {

    public static Crawler1_Trigger Instance;

    public GameObject cameraEye;

    public bool go;


    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    // Use this for initialization
    void Start () {
        go = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cameraEye)
        {
            go = true;
            //Debug.Log("Hit");
        }
    }

}
