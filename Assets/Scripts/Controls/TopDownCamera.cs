using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    //Camera sets target at the main character
    public GameObject target;
    public Vector3 offset = new Vector3(0, 0, -1);


    void FixedUpdate()
    {
        //Camera fixes on player
        if (target)
        {
            //Camera always focuses exactually to the character when the player is moving
            transform.position = new Vector3(
                target.transform.position.x + offset.x,
                target.transform.position.y + offset.y,
                target.transform.position.z + offset.z);
        }
    }
}
