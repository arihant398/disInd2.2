using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionTest : MonoBehaviour
{
	public Text Scoretext;
	public int initialScore = 0;
    public GameObject panel;


  	private void recount(){
  		initialScore -= 20;
    	Scoretext.text = initialScore.ToString();
  	}

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
    	if(col.gameObject.name == "Mine Sample"){
    		col.gameObject.SetActive(false);
    		recount();
            Time.timeScale = 0;
            Debug.Log("Collision Worked");
            panel.SetActive(true);
    	}
    }
}
