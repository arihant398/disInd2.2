using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class up : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
	bool isPressed = false;
	public GameObject player;

    void Update()
    {
        if(isPressed){
        	player.transform.Translate(0,8f,0);
        }
    }

    public void OnPointerDown(PointerEventData eventData){
    	isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData){
    	isPressed = false;
    }
}

