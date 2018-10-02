using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour {

    public CubeScript Movement;


	private void OnCollisionEnter(Collision collisioninfo)
	{

        if (collisioninfo.collider.tag == "Obstacle"){

            Movement.enabled = false;
            Debug.Log("We hit a Obstacle");



        }

	}




}
