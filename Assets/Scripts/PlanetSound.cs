using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSound : MonoBehaviour
{
    // Use: attach to a planet to make its sound's volume affected by distance from the camera....
    // ...or whatever gameObject you assign to the below variable. 

    // Make sure these references are assigned in the inspector
    [Header("References")]

    // we care about distance from camera
    public GameObject camera; 
    // we want to affect the volume of the audio source
    public AudioSource audio;

    [Header("Variables")]
    // wa want to modify the volume using math
    public float falloff;


    void Start()
    {
        
    }
        
    void Update()
    {
        // setup variable with default value
        float dist = 0f;

        // we want to measure the distance between this object (transform.position) and the camera (camera.transform.position)
        // Use Vector3.Distance to set dist

        // dist = Vector3.Distance (???, ???);

        
        // get reciprocal; far away will make it quiet, and visa versa
        // the greater the falloff, the faster the effect
        float newVolume = 1f / (dist * falloff);

        // set the volume of the audiosource componenet

        // audio.volume = ???;
    }
}
