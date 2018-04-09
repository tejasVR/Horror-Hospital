using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampBreakManager : MonoBehaviour {

    public Light light;

    public AudioSource lightHum;

    public AudioClip brokenFlicker;
    public AudioClip breakLight;

    public GameObject trigger;

    public GameObject picture;


    // Use this for initialization
    void Start()
    {

        //timerLight = Random.Range(3, 5);
        //light.enabled = true;

        //flicker = false;

        StartCoroutine(Flicker());



        //timerLight = Random.Rage

        //light = GetComponent<Light>();


    }


    IEnumerator Flicker()
    {
        while (true)
        {
            //Start at random
            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(0f, 3f));

            //PreFlicker
            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(0f, .5f));

            //First flicker
            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.2f, .4f));

            //Second flicker
            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.3f, .6f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.1f, .15f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.2f, .3f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.4f, .7f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.05f, .1f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(0f, .15f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(0f, 2f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(1f, 3f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(0f, .3f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(0f, .3f));
        }
    }

    IEnumerator LampBreak()
    {
        while(true)
        {
            AudioSource.PlayClipAtPoint(brokenFlicker, transform.position); //~~ 1.1 seconds in length

            light.enabled = true;
            yield return new WaitForSeconds(.3f);

            light.enabled = false;
            yield return new WaitForSeconds(.1f);

            light.enabled = true;
            yield return new WaitForSeconds(.2f);

            //.5 seconds

            light.enabled = false;
            yield return new WaitForSeconds(.05f);

            light.enabled = true;
            yield return new WaitForSeconds(.1f);

            light.enabled = false;
            yield return new WaitForSeconds(.06f);

            light.enabled = true;
            yield return new WaitForSeconds(.04f);

            //.75 seconds

            light.enabled = false;
            yield return new WaitForSeconds(.04f);

            light.enabled = true;
            yield return new WaitForSeconds(.16f);

            light.enabled = false;
            yield return new WaitForSeconds(.02f);

            light.enabled = true;
            yield return new WaitForSeconds(.1f);

            //1.07 seconds

            AudioSource.PlayClipAtPoint(breakLight, transform.position); //~~ 1.1 seconds in length

            light.enabled = false;

            this.gameObject.SetActive(false);

            picture.SetActive(true);

            yield break;

        }
    }

    // Update is called once per frame
    void Update()
    {

        if (light.enabled)
        {
            lightHum.Play();
            //Debug.Log("LightHumSound");
        }
        else
        {
            lightHum.Stop();
        }

        if (LampBreakTrigger.Instance.breakLamp == true)
        {
            StopAllCoroutines();
            StartCoroutine(LampBreak());
            LampBreakTrigger.Instance.breakLamp = false;
            //trigger.SetActive(false);

        }

    }

}
