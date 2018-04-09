using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class LightManager : MonoBehaviour {

    public SteamVR_TrackedObject trackedObj;

    public GameObject rigEye;

    public Light light;

    public bool isLight;

    public GameObject humSound;
    private AudioSource audioSource;

    public AudioClip clickDown;
    public AudioClip clickUp;
    //public AudioClip lightHum;


    // Use this for initialization
    void Start () {

        light.enabled = true;

        light.intensity = 0;
        light.range = 0;

        isLight = true;

        audioSource = humSound.GetComponent<AudioSource>();

        audioSource.Play();
		
	}
	
	// Update is called once per frame
	void Update () {

        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);

        //Debug.Log(trackedObj);

        //Debug.Log(device.angularVelocity);

        //Controller Shakle for Light
        if (device.velocity.magnitude >= .5f)
        {
            light.intensity = Mathf.Lerp(light.intensity, light.intensity + .15f, Time.deltaTime * 5);
            isLight = true;
            light.range = Mathf.Lerp(light.range, light.range + .25f, Time.deltaTime * 5);

            if (light.intensity >= 2)
            {
                light.intensity = 2;
            }

            if (light.range >= 4)
            {
                light.range = 4f;
            }

        } else
        {
            light.intensity -= .002f;
            light.range -= .002f;
            isLight = false;
        }

        audioSource.volume = light.intensity / 5;

        ////Touchpad CLick for Light
        /*if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            AudioSource.PlayClipAtPoint(clickDown, transform.position);

            if (isLight == false)
            {
                light.enabled = true;
                rigEye.GetComponent<Grayscale>().enabled = false;
                audioSource.Play();
                //AudioSource.PlayClipAtPoint(lightHum, transform.position);
                //audioSource.loop
                //Debug.Log("Light on");
            }

            if (isLight == true)
            {
                light.enabled = false;
                rigEye.GetComponent<Grayscale>().enabled = true;
                audioSource.Stop();

                //Debug.Log("Light off");
            }
        }

        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            AudioSource.PlayClipAtPoint(clickUp, transform.position);

            if (light.enabled == true)
            {
                isLight = true;

                //Debug.Log("Yes isLight");

            }

            if (light.enabled == false)
            {
                isLight = false;

                //Debug.Log(" Not isLight");

            }

        }*/
       

        /*if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad) && isLight == true)
        {
            light.enabled = false;

            //if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
            //{
                isLight = false;
            //}

            Debug.Log("Light off");

        }*/



        /*}
        else if (isLight == true)
        {
            light.enabled = false;
            */
    }
}
