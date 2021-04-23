using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class rightButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
	bool isPressed = false;
	public GameObject player;

    void Update()
    {
        if(isPressed){
        	player.transform.Translate(0,0,8f);
        }
    }

    public void OnPointerDown(PointerEventData eventData){
    	isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData){
    	isPressed = false;
    }
}

