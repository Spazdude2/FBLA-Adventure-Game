using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MainMenu : MonoBehaviour
{
    public Canvas startMenu;
    public Transform Player;
    public Transform sun;

	public Canvas PS;
	public int timer = 100;

	public Canvas controls;
	public Canvas music;

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;

	public Button back;


	// Use this for initialization
	void Start ()
    {
		Cursor.lockState = CursorLockMode.None;

        quitMenu = quitMenu.GetComponent<Canvas>();
        quitMenu.enabled = false;

		music = music.GetComponent<Canvas> ();
		controls = controls.GetComponent<Canvas> ();

        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
		back = back.GetComponent<Button>();

        startMenu = startMenu.GetComponent<Canvas>();

        Player.GetComponent<FirstPersonController>().enabled = false;
        sun.GetComponent<Sun>().Orbit = 0;

		PS = PS.GetComponent<Canvas> ();

		PS.gameObject.SetActive (true);
		startMenu.gameObject.SetActive (false);

		Time.timeScale = 0;
	}
	
    public void ExitPress()
    {
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }

    public void StartLevel()
    {
        startMenu.gameObject.SetActive(false);
        Player.GetComponent<FirstPersonController>().enabled = true;
        sun.GetComponent<Sun>().Orbit = sun.GetComponent<Sun>().setOrbit;
        Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.Locked;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

	public void Music()
	{
		music.gameObject.SetActive (true);
		startMenu.gameObject.SetActive (false);
	}

	public void Controls()
	{
		controls.gameObject.SetActive (true);
		startMenu.gameObject.SetActive (false);
	}

	public void Back()
	{
		controls.gameObject.SetActive (false);
		music.gameObject.SetActive (false);
		startMenu.gameObject.SetActive (true);

	}


	void Update()
	{
		timer--;

		if (timer == 0) 
		{
			PS.gameObject.SetActive (false);
			startMenu.gameObject.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			startMenu.gameObject.SetActive (true);
			controls.gameObject.SetActive (false);
			music.gameObject.SetActive (false);
			quitMenu.gameObject.SetActive (false);
			Player.GetComponent<FirstPersonController>().enabled = false;
			sun.GetComponent<Sun>().Orbit = 0;
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
