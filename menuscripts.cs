using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuscripts : MonoBehaviour {

    public Canvas select;
    public Canvas home;
    public Canvas tutorial;
    public GameObject player;
    
    public GameObject teacherboard;

    public AudioSource soundclick;

    void Start()
    {
        select.enabled = false;
        tutorial.enabled = false;
        
    }



    public void ChangeToScene(string sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
    
	public void clickstart()
    {
        select.enabled = true;
        home.enabled = false;
        player.SetActive(false);
        
        soundclick.Play();
    }
    public void backhomefromselect()
    {
        select.enabled = false;
        home.enabled = true;
        player.SetActive(true);
        
        soundclick.Play();
    }
    public void clicktutorial()
    {
        tutorial.enabled = true;
        home.enabled = false;
        teacherboard.SetActive(false);
        player.SetActive(false);
        
        soundclick.Play();
    }
    public void backhomefromtutorial()
    {
        tutorial.enabled = false;
        home.enabled = true;
        teacherboard.SetActive(true);
        player.SetActive(true);
       
        soundclick.Play();
    }
    

}
