using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMove : MonoBehaviour {

    public static PointMove Instance;

    public SteamVR_TrackedObject trackedObj;

    public Vector3 hitPoint;

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
		
	}
	
	// Update is called once per frame
	void Update () {

        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 30f))
            {
                hitPoint = hit.point;
            }
        }		
	}
}
