using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public static CameraFollow Instance;

    public SteamVR_TrackedObject trackedObj;
    //public Vector3 moveCamera;
    //public Vector3 lookPos;

    //public GameObject followStart;

    //public bool isTriggerPressed;

    //public Vector2 triggerAxis;
    public float triggerAxis;

    public float triggerMove;

    //private float triggerPrevious;

    //public Vector3 target;

    //private float

    //public float triggerAxisY;


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

        /*
        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);

        triggerAxis = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).x;

        if (triggerAxis > .009)
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.position.x + triggerAxis, Time.deltaTime), transform.position.y, transform.position.z);

            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(transform.position.z, transform.position.z + triggerAxis, Time.deltaTime));

            transTranlate = transform.Translate(0, 0, triggerAxis/10, Space.Self);

        //    transform.forward;

        }
        else
        {
            //transform.position = new Vector3(Mathf.Lerp(transform.position.x, followStart.transform.position.x, Time.deltaTime), transform.position.y, transform.position.z);
            //transform.Translate(0, 0, Mathf);
            transform.position = Vector3.Lerp(transform.position, followStart.transform.position, Time.deltaTime);
        }

        //if ()


        //if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
        //    Debug.Log("hello!");
        }
        

        //lookPos = new Vector3(0f, trackedObj.transform.position.y, 0f);
        //transform.LookAt(trackedObj.transform.forward);

        
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);


        //triggerAxisY = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).x;

        //triggerAxis = device.GetAxis(SteamVR_Controller.ButtonMask.Trigger);
        //moveCamera = new Vector3(triggerAxisX, 0f, 0f);
        //if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger)) {

        //  Debug.Log("Hi1");


        //}
        */
    }

    void FixedUpdate()
    {
        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
        transform.forward = trackedObj.transform.forward;

        //triggerPrevious = triggerAxis;

        triggerAxis = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).x;

        /*if (triggerPrevious < triggerAxis)
        {
            isTriggerPressed = true;
        } else
        {
            isTriggerPressed = false;
        }*/

        //if (triggerAxis > 0)
        //{
            //transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.position.x + triggerAxis, Time.deltaTime), transform.position.y, transform.position.z);

            //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(transform.position.z, transform.position.z + triggerAxis, Time.deltaTime));

            //transform.localPosition = new Vector3(0f, 0f, Mathf.Lerp(0f, triggerAxis, Time.deltaTime));

            //triggerMove = Mathf.Lerp(triggerMove, triggerAxis, Time.deltaTime * 2);

            transform.localPosition = new Vector3(0f, 0f, triggerAxis);


            //target = new Vector3(0f, 0f, triggerAxis);

            //transform.localPosition = Vector3.Lerp(Vector3.zero, target, Time.deltaTime);


            //transform.position = new Vector3()

            //transform.Translate(0, 0, triggerAxis / 100, Space.Self);

        //}
        //else
        //{
            //transform.position = new Vector3(Mathf.Lerp(transform.position.x, followStart.transform.position.x, Time.deltaTime), transform.position.y, transform.position.z);
            //transform.Translate(0, 0, Mathf);
            //transform.position = Vector3.Lerp(transform.position, followStart.transform.position, Time.deltaTime);
        //}

        //triggerPrevious = triggerAxis;

        


    }
}
