using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class targetBulletCollision : MonoBehaviour
{
	public collisionTest ct;

  	private void recount(){
  		ct.initialScore += 50;
    	ct.Scoretext.text = ct.initialScore.ToString();
  	}

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
    	if(col.gameObject.name == "Missile(Clone)"){
    		Destroy(col.gameObject);
    		Destroy(this.gameObject);
    		recount();
    	}
    }
}
