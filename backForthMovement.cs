using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backForthMovement : MonoBehaviour
{

	public float speed = 200f;
	float startX;
	float startY;
	float startZ;
	public float distance = 400;

	public int movementType;

    void Start()
    {
		startX = transform.position.x;
		startY = transform.position.y;  
		startZ = transform.position.z;    
    }

    void Update()
    {
    	if(movementType == 1){
			transform.position = new Vector3(startX+Mathf.PingPong (Time.time*speed,distance),transform.position.y,transform.position.z);
    	}
    	else if(movementType == 2){
			transform.position = new Vector3(transform.position.x,transform.position.y+Mathf.PingPong (Time.time*20,50),transform.position.z);
    	}
    	else if(movementType == 3){
			transform.position = new Vector3(transform.position.x,transform.position.y,startZ+Mathf.PingPong (Time.time*speed,distance));
    	}
    	else{

		}
   }
}
