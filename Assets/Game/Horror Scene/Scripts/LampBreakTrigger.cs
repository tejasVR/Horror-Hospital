using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampBreakTrigger : MonoBehaviour {

    public static LampBreakTrigger Instance;

    public GameObject cameraEye;

    public bool breakLamp;


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
        breakLamp = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cameraEye)
        {
            breakLamp = true;
            //Debug.Log("Hit");
        }
    }
}
