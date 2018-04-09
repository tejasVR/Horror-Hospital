using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampFlicker : MonoBehaviour {

    //public float timerLight;

    //public float timerFlicker;
    //public float timerFlicker2;

    //public float timerFlicker3;

    //public bool flicker;

    public Light light;

    public AudioSource lightHum;

    public GameObject trigger;

    public bool go = false;



    // Use this for initialization
    void Start () {

        //timerLight = Random.Range(3, 5);
        //light.enabled = true;

        //flicker = false;

        StartCoroutine(Flicker());



        //timerLight = Random.Rage

        //light = GetComponent<Light>();
        
		
	}


    IEnumerator Flicker ()
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


    IEnumerator ScareFlicker()
    {
        while (true)
        {
            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.1f, .3f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.1f, .3f));
            //Debug.Log("Scare");

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.1f, .4f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.1f, .2f));

            StartCoroutine(Flicker());

            yield break;            
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (light.enabled)
        {
            lightHum.Play();
            //Debug.Log("LightHumSound");
        } else
        {
            lightHum.Stop();
        }

        if (Crawler1_Trigger.Instance.go == true && go == false)
        {
            StopAllCoroutines();
            StartCoroutine(ScareFlicker());
            go = true;
            //Crawler1_Trigger.Instance.go = false;
            //Destroy(trigger);
        }
        


        //timerLight -= Time.deltaTime;

        /*if (timerLight <= 0f && flicker == false)
        {
            flicker = true;
            //Flicker1();
            Debug.Log("No light");
            timerLight = 0f;
        }
        */

        /*if (flicker == true)
        {
            //First flicker
            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.2f, .4f));

            //Second flicker
            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.3f, .6f));

            light.enabled = false;
        }*/
		
	}

    /*void Flicker1()
    {
        flicker = true;
        light.enabled = false;
        timerFlicker = Random.Range(.2f, .4f);
        timerFlicker -= Time.deltaTime;
        if (timerFlicker <= 0f)
        {
            Flicker2();
        }
            
    }

    void Flicker2()
    {
        light.enabled = true;
        timerFlicker = Random.Range(.3f, .5f);
        timerFlicker -= Time.deltaTime;
        if (timerFlicker <= 0f)
        {
            light.enabled = true;
            Flicker2();
        }

    }*/

}
