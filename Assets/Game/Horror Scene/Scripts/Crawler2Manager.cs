using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crawler2Manager : MonoBehaviour {

    private bool playScreech;

    public Animator anim;
    public GameObject cameraEye;


    public Vector3 rotateY;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //transform.forward =

        //rotateY = 

        //transform.rotation = new Quaternion(0f, cameraHead.transform.position.z, 0f, 0f);

        if (Crawler2_Trigger.Instance.go == true)
        {
            transform.position += new Vector3(-.04f, 0f, 0);
            PlayScreech();
            anim.Play("pounce");
        }

    }

    public void PlayScreech()
    {
        if (playScreech == false)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            playScreech = true;
            //gameObject.PlayAnimation(pounce);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == cameraEye)
        {

            Debug.Log("Restart");
            SceneManager.LoadScene("Horror_2");

            //Debug.Log("Hit");
        }
    }
}
