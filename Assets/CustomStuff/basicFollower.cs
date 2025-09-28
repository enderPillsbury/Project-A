using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFollower : MonoBehaviour
{
    //set the values in the inspector
    public Transform target; //drag and drop player object in the inspector
    public float within_range;
    public float speed;

    void Update ()
    {
        //get the distance between the player and enemy (this object)
        float dist = Vector3.Distance(target.position, transform.position);

        //check if it is within the range you set
        if (dist <= within_range)
        {
            //move to target(player) 
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        }
        //else, if it is not in range, it will not follow player
    }
}   //Code by user joauimleitemendes on the Unity Q&A Forums
