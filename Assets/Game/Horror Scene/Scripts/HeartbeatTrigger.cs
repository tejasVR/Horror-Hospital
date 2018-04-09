using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartbeatTrigger : MonoBehaviour {

    public static HeartbeatTrigger Instance;

    public AudioSource audio;

    public GameObject cameraEye;

    public GameObject crawler2;

    public bool go;

    public float distanceMax;
    public float distance;


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
        go = false;
        //float distanceDynamic = Vector3.Distance(cameraEye.transform.position, crawler2.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        if (go == true)
        {
            distance = Vector3.Distance(cameraEye.transform.position, crawler2.transform.position);

            audio.pitch = 1+ ((distanceMax - distance) / distanceMax) * 1.5f;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cameraEye)
        {

            audio.Play();
            distanceMax = Vector3.Distance(cameraEye.transform.position, crawler2.transform.position);



            //float distance = Vector3.Distance(cameraEye.transform.position, crawler2.transform.position);

            //audio.pitch = 1 + (distance * .15f / distance);

            go = true;
            //Debug.Log("Hit");
        }
    }
}
