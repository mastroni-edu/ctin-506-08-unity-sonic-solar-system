using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Use: attach to a parent of an orbiting child.  This script makes a GameObject rotate.
    // Therefore if you want that child to rotate, you have to give it a local position offset (away from its parent)

    // This is the value we'll use to rotate the object. It's public, so adjust this value in the inpsector for each instance.
    public float ySpeed = 1;

    void Start()
    {
        
    }

    void Update()
    {
        // This function is used to rotate an object locally (note Space.Self, instead of Space.World)
        // Replace one of the zeros with the ySpeed to make this object rotate on its y-axis
        transform.Rotate(0f, 0f, 0f, Space.Self);
    }
}
