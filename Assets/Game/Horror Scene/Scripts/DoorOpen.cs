using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public Quaternion rot = Quaternion.Euler (0, -167, 0);

    private bool playCreak;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

        if (DoorTrigger.Instance.goDoor == true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime / 5);
            PlayCreak();

        }

    }

    public void PlayCreak()
    {
        if (playCreak == false)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            playCreak = true;
        }
    }

}
