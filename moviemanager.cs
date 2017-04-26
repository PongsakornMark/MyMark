using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moviemanager : MonoBehaviour {

    public GameObject first;
    public Button firstnext;
    public GameObject second;
    public Button secondnext;

    public AudioSource soundclick;
    public GameObject bgm;

    
    

	// Use this for initialization
	void Start () {

        second.SetActive(false);
        
        
	}

    public void firstnextbutton()
    {
        first.SetActive(false);
        second.SetActive(true);
        soundclick.Play();

    }
    
    

    

}
