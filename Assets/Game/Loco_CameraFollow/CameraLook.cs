using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour {

    public SteamVR_TrackedObject trackedObj;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
        //transform.LookAt(trackedObj.transform.forward);

        var eular = trackedObj.transform.rotation.eulerAngles;
        var rotY = Quaternion.Euler(0, eular.y, 0);

        transform.rotation = rotY;
        
        //transform.localRotation = new Quaternion(0f, trackedObj.transform.rotation.y, 0f, 0f);

        //Debug.Log(trackedObj.transform.rotation.y);

        //transform.rotation = trackedObj.transform.rotation;

    }
}
