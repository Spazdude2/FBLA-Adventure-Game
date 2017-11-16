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

    public Canvas quitMenu;
    public Button startText;
    public Button exitText;


	// Use this for initialization
	void Start ()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        quitMenu.enabled = false;
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        startMenu = startMenu.GetComponent<Canvas>();
        Player.GetComponent<FirstPersonController>().enabled = false;
        sun.GetComponent<Sun>().Orbit = 0;
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
    }

    public void ExitGame()
    {
        
    }
}
