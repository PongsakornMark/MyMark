using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuingame : MonoBehaviour {

    public Canvas blur;
    public Canvas continuegame;
    public Canvas menucan;
    public Button menubutton;
    public GameObject mute;
    public GameObject canopsund;
    public GameObject bmg;
    
	// Use this for initialization
	void Start () {

        continuegame.enabled = false;
        mute.SetActive(false);
        
        menucan.enabled = false;
	}

    void Update()
    {

        if (continuegame.isActiveAndEnabled & Input.GetMouseButtonDown(0))
        {
            blur.enabled = false;
            continuegame.enabled = false;
            Time.timeScale = 1;
        }
        
    }
	
	public void exitpress()
    {
        menucan.enabled = true;
        blur.enabled = true;
        Time.timeScale = 0;
        
    }
    public void nopress()
    {
        menucan.enabled = false;
        
        continuegame.enabled = true;
        
    }

    public void home()
    {
        Application.LoadLevel("home");
        Time.timeScale = 1;
    }

    public void retreat()
    {
        Application.LoadLevel("suctest");
        Time.timeScale = 1;
    }
    public void retreat2()
    {
        Application.LoadLevel("suctest2");
        Time.timeScale = 1;
    }

    public void ChangeToScene(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void mutesoud()
    {
        bmg.SetActive(true);
        mute.SetActive(false);
        canopsund.SetActive(true);
    }
    public void opsound()
    {
        bmg.SetActive(false);
        mute.SetActive(true);
        canopsund.SetActive(false);
    }
}
