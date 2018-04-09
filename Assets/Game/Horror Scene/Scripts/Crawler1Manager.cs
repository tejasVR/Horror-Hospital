using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler1Manager : MonoBehaviour {

    //public AudioClip screech;
    private bool playScreech;
    //private bool move;

	// Use this for initialization
	void Start () {

       
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Crawler1_Trigger.Instance.go == true)
        {
            transform.position += new Vector3(-.09f, 0f, 0);
            PlayScreech();

        }
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "CrawlerDestroy")
        {
            Destroy(gameObject);
            //Debug.Log("DestroyDemon");
        }
    }

    public void PlayScreech()
    {
        if (playScreech == false)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            playScreech = true;
        }
    }


}
