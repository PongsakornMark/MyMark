using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {


    public int count;
    public Text scorecount;

    public AudioSource sounddeath;



    // Use this for initialization
    void Start() {

        count = 0;
        scorecount.text = "คะแนน  :  " + count.ToString();


    }


    

        void OnTriggerEnter(Collider col)
        {
            if (col.tag == "coin")
            {
                col.gameObject.SetActive(false);
                count = count + 10;
                scorecount.text = "คะแนน  :  " + count.ToString();
                GetComponent<AudioSource>().Play();

            }
            if (col.tag == "death")
            {
                count = count - 20;
                scorecount.text = "คะแนน  :  " + count.ToString();
                sounddeath.Play();
            }
            
        }

    public void trueanswer(int score)
    {
        count += score;
        scorecount.text = "คะแนน  :  " + count.ToString();

    }

    public void falseanswer(int score)
    {
        count -= score;
        scorecount.text = "คะแนน  :  " + count.ToString();
    }

}
