using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vButtonTest : MonoBehaviour
{
	public GameObject vBtn;
	public GameObject vBtn2;
	public GameObject vBtn3;
	public GameObject vBtn4;
	public GameObject vBtn5;
	public GameObject vBtn6;
	public GameObject vBtn7;
	public GameObject cube;
	public GameObject player;

	public shootTest st;

	bool isPressedForward = false;
	bool isPressedBack = false;
	bool isPressedUp = false;
	bool isPressedDown = false;
	bool isPressedRotateClockwise = false;
	bool isPressedRotateAntiClockwise = false;
	bool isPressedShoot = false;

	public float moveSpeed = 5f;
	public float rotateSpeed = 2f;


    void Start()
    {
    	vBtn = GameObject.Find("VirtualButton1");
        vBtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    	vBtn.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    	vBtn2 = GameObject.Find("VirtualButton2");
        vBtn2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    	vBtn2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    	vBtn3 = GameObject.Find("VirtualButton3");
        vBtn3.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    	vBtn3.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    	vBtn4 = GameObject.Find("VirtualButton4");
        vBtn4.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    	vBtn4.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    	vBtn5 = GameObject.Find("VirtualButton5");
        vBtn5.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    	vBtn5.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    	vBtn6 = GameObject.Find("VirtualButton6");
        vBtn6.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    	vBtn6.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    	vBtn7 = GameObject.Find("VirtualButton7");
        vBtn7.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
    	vBtn7.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    void Update(){
    	if(isPressedForward){
    		player.transform.Translate(0,0,moveSpeed);
    	}
    	if(isPressedBack){
    		player.transform.Translate(0,0,-moveSpeed);
    	}
    	if(isPressedUp){
    		player.transform.Translate(0,moveSpeed,0);
    	}
    	if(isPressedDown){
    		player.transform.Translate(0,-moveSpeed,0);
    	}
    	if(isPressedRotateClockwise){
    		player.transform.Rotate(0,rotateSpeed,0);
    	}
    	if(isPressedRotateAntiClockwise){
    		player.transform.Rotate(0,-rotateSpeed,0);
    	}
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
	    Debug.Log("*** button Pressed " + vb.VirtualButtonName);

	    if(vb.VirtualButtonName == "VirtualButton1"){
	    	isPressedForward = true;
	    }
	    if(vb.VirtualButtonName == "VirtualButton2"){
	    	isPressedBack = true;
	    }
	    if(vb.VirtualButtonName == "VirtualButton3"){
	    	isPressedUp = true;
	    }
	    if(vb.VirtualButtonName == "VirtualButton4"){
	    	isPressedDown = true;
	    }
	    if(vb.VirtualButtonName == "VirtualButton5"){
	    	st.shootObj();
	    	isPressedShoot = true;
	    }
	    if(vb.VirtualButtonName == "VirtualButton6"){
	    	isPressedRotateClockwise = true;
	    }
	    if(vb.VirtualButtonName == "VirtualButton7"){
	    	isPressedRotateAntiClockwise = true;
	    }

	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
	    Debug.Log("*** button Released " + vb.VirtualButtonName);

	    if(vb.VirtualButtonName == "VirtualButton1"){
	    	isPressedForward = false;
	    }
	    if(vb.VirtualButtonName == "VirtualButton2"){
	    	isPressedBack = false;
	    }
	    if(vb.VirtualButtonName == "VirtualButton3"){
	    	isPressedUp = false;
	    }
	    if(vb.VirtualButtonName == "VirtualButton4"){
	    	isPressedDown = false;
	    }
	    if(vb.VirtualButtonName == "VirtualButton5"){
	    	isPressedShoot = false;
	    }
	    if(vb.VirtualButtonName == "VirtualButton6"){
	    	isPressedRotateClockwise = false;
	    }
	    if(vb.VirtualButtonName == "VirtualButton7"){
	    	isPressedRotateAntiClockwise = false;
	    }
	}
}
