using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour 
{
	[SerializeField]
	Camera firstPCamera = null;
	[SerializeField]
	Camera thirdPCamera = null;
	[SerializeField]
	Camera backCamera = null;

	private bool switchCam = false;
	private bool backCam = false;


	// Use this for initialization
	void Start () 
	{
		firstPCamera.GetComponent<Camera> ().enabled = false;
		thirdPCamera.GetComponent<Camera> ().enabled = true;
		backCamera.GetComponent<Camera> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("t")) 
		{
			switchCam = !switchCam;
			backCam = false;
		}

		if (Input.GetKeyDown ("b")) 
		{
			switchCam = false;
			backCam = true;
		}

		if (switchCam == true) 
		{
			firstPCamera.GetComponent<Camera> ().enabled = true;
			thirdPCamera.GetComponent<Camera> ().enabled = false;
			backCamera.GetComponent<Camera> ().enabled = false;
		} 

		else if (backCam == true) 
		{
			firstPCamera.GetComponent<Camera> ().enabled = false;
			thirdPCamera.GetComponent<Camera> ().enabled = false;
			backCamera.GetComponent<Camera> ().enabled = true;
		} 

		else 
		{
			firstPCamera.GetComponent<Camera> ().enabled = false;
			thirdPCamera.GetComponent<Camera> ().enabled = true;
			backCamera.GetComponent<Camera> ().enabled = false;
		}

	}

}
