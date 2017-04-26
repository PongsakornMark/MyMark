using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

    public Transform movingPlatForm;
    public Transform position1;
    public Transform position2;
    public Vector3 newPosition;
    public string currentState; 
    public float smooth;
    public float resetTime;
    
    

    public GameObject teacher;
    public GameObject board;

    public AudioSource soundcan;

    public GameObject canvasmovie;

    public GameObject walkplayer;
    public GameObject sitplayer;

    // Use this for initialization
    void Start () {
        ChangeTarget();
        sitplayer.SetActive(false);
        canvasmovie.SetActive(false);
        teacher.SetActive(false);
        board.SetActive(false);
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        movingPlatForm.position = Vector3.Lerp(movingPlatForm.position, newPosition, smooth * Time.deltaTime);
	}

    void ChangeTarget()
    {
        if(currentState =="Moving To Position 1")
        {
            currentState = "Moving To Position 2";
            newPosition = position2.position;
            walkplayer.SetActive(false);
            sitplayer.SetActive(true);
            teacher.SetActive(true);
            board.SetActive(true);
            
            Invoke("enablecanvas", 7f);
            
        }
        else if (currentState == "Moving To Position 2")
        {
            currentState = "Moving To Position 1";
            newPosition = position1.position;
            

        }
        else if (currentState == "")
        {
            currentState = "Moving To Position 2";
            newPosition = position2.position;
        }
        Invoke("ChangeTarget", resetTime);
    }
    void enablecanvas()
    {
        canvasmovie.SetActive(true);
        soundcan.Play();
    }
}
