using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        

    }
    //キューブ同士、または地面に接した時に音を鳴らす

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CubeTag" && collision.gameObject.tag == "groundtag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
