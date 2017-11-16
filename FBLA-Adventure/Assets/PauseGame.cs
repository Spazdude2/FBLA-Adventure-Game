﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour
{
    public Transform canvas;
    public Transform Player;
	public Transform sun;
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

	}
    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
			Player.GetComponent<FirstPersonController>().enabled = false;
			sun.GetComponent<Sun> ().Orbit = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            Player.GetComponent<FirstPersonController>().enabled = true;
			sun.GetComponent<Sun> ().Orbit = sun.GetComponent<Sun> ().setOrbit;
            Cursor.lockState = CursorLockMode.Locked;

        }
    }
}
