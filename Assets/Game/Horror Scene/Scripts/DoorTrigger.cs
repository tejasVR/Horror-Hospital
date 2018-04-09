using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

    public static DoorTrigger Instance;

    public GameObject cameraEye;

    public bool goDoor;


    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    // Use this for initialization
    void Start()
    {
        goDoor = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cameraEye)
        {
            goDoor = true;
            //Debug.Log("Hit");
        }
    }
}
