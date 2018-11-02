using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFlashOn : MonoBehaviour {

    public GameObject flashlight;
    public GameObject spotlight;
    public Light beamlight;
    

    // Use this for initialization
    void Start () {
		flashlight = GameObject.Find("flashlight");
        spotlight = GameObject.Find("spotlight");
        beamlight = spotlight.GetComponent<Light>();

        spotlight.setActive(false);
    }

    public void LightOn()
    {
        spotlight.setActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void onTriggerEnter(Collider hand)
    {
        if (coll.CompareTag("hand"))
        {
         
            LightOn();
        }

    }
}
