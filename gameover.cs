using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameover : MonoBehaviour {

    public Canvas first;
    public Canvas second;
    public Button re;
    public Button home;
    public Button exit;

    public Button yes;
    public Button no;

    // Use this for initialization
    void Start()
    {
        second.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restart()
    {
        Application.LoadLevel("suctest");
    }
    public void homebutton()
    {
        Application.LoadLevel("home");
    }

    public void exitbutton()
    {
        second.enabled = true;
        first.enabled = false;
    }

    public void yesbutton()
    {
        Application.Quit();
    }
    public void nobutton()
    {
        second.enabled = false;
        first.enabled = true;
    }
}
