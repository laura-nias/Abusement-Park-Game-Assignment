using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour {

	private Transform mainMenu;
    public GameObject pauseScreen;

    public void Start()
    {
        pauseScreen.SetActive(false);
    }
    public void Update()
    {
        

        if ((Input.GetKeyDown(KeyCode.Escape)) || (Input.GetKeyDown(KeyCode.P))|| (Input.GetButtonDown("Start")))
        {
            PauseGame();
        }

    }
    public void StartGame()
	{
		SceneManager.LoadScene ("CharacterSelection");
    }
	public void QuitGame()
	{
        Application.Quit();
	}
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PauseGame()
    {
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
    }
  
}