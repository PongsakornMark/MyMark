using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class meneexit : MonoBehaviour {

    public Canvas quitmenu;
    public Button exittext;
    public Canvas homecan;
    public GameObject player;
    

    public AudioSource soundclick;

	// Use this for initialization
	void Start () {

        quitmenu = quitmenu.GetComponent<Canvas>();
        exittext = exittext.GetComponent<Button>();
        quitmenu.enabled = false;

	}
	
	public void ExitPress()
    {
        quitmenu.enabled = true;
        exittext.enabled = false;
        homecan.enabled = false;
        player.SetActive(false);
        
        soundclick.Play();
    }

    public void NoPress()
    {
        quitmenu.enabled = false    ;
        exittext.enabled = true;
        homecan.enabled = true;
        player.SetActive(true);
        
        soundclick.Play();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
