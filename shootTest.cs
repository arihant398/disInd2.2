using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootTest : MonoBehaviour
{
    public GameObject bullet;
    public Transform itemtransform;
    public float speed = 1000f;
    Vector3 startPos; 

    void Start(){
    	startPos = transform.position;   
    }

    void Update()
    {
    	Quaternion rotation = itemtransform.rotation;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(bullet, transform.position, rotation) as GameObject; 
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddRelativeForce(Vector3.forward * speed);
            instBulletRigidbody.freezeRotation = false;
            instBulletRigidbody.constraints = RigidbodyConstraints.None;
            //Destroy(instBullet,2f);
        }
    }

    public void shootObj(){
    	Quaternion rotation = itemtransform.rotation;
    	GameObject instBullet = Instantiate(bullet, transform.position, rotation) as GameObject; 
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddRelativeForce(Vector3.forward * speed);
            instBulletRigidbody.freezeRotation = false;
            instBulletRigidbody.constraints = RigidbodyConstraints.None;
            //Destroy(instBullet,2f);
    }
}