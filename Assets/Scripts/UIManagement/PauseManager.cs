using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {
    public GameObject pauseMenuObject;
    bool isPaused;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Pause"))
        {
            pauseGame();
        }
	}

    public void pauseGame()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        pauseMenuObject.SetActive(isPaused);
    }
}
