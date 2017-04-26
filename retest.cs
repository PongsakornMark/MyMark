using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class retest : MonoBehaviour
{
    private int countex;
    private score countscore;
    public Text scorecountend;
    public Text scorecountend2;
    public Text scorecountend3;
    public Text countexam;

    public Canvas blur;

    public AudioSource fakebridgesound;

    public GameObject fakebridge;
    public GameObject fakebridge2;
    public GameObject fakebridge3;
    public GameObject fakebridge4;
    public GameObject fakebridge5;
    public GameObject fakebridge6;
    public GameObject fakebridge7;
    public GameObject fakebridge8;
    public GameObject fakebridge9;
    public GameObject fakebridge10;
    public GameObject fakebridge11;
    public GameObject fakebridge12;
    public GameObject fakebridge13;
    public GameObject fakebridge14;
    public GameObject fakebridge15;
    public GameObject fakebridge16;
    public GameObject fakebridge17;
    public GameObject fakebridge18;
    public GameObject fakebridge19;
    public GameObject fakebridge20;
    public GameObject fakebridge21;
    public GameObject fakebridge22;
    public GameObject fakebridge23;
    public GameObject fakebridge24;
    public GameObject fakebridge25;
    public GameObject fakebridge26;
    public GameObject fakebridge27;
    public GameObject fakebridge28;
    public GameObject fakebridge29;
    public GameObject fakebridge30;
    public GameObject fakebridge31;
    public GameObject fakebridge32;
    public GameObject fakebridge33;
    public GameObject fakebridge34;
    public GameObject fakebridge35;
    public GameObject fakebridge36;
    public GameObject fakebridge37;
    public GameObject fakebridge38;
    public GameObject fakebridge39;
    public GameObject fakebridge40;
    public GameObject fakebridge41;
    public GameObject fakebridge42;
    public GameObject fakebridge43;
    public GameObject fakebridge44;
    public GameObject fakebridge45;
    public GameObject fakebridge46;
    public GameObject fakebridge47;
    public GameObject fakebridge48;
    public GameObject fakebridge49;
    public GameObject fakebridge50;
    public GameObject fakebridge51;
    public GameObject fakebridge52;
    public GameObject fakebridge53;

    public GameObject bridgedelay1;
    public GameObject bridgedelay2;
    public GameObject bridgedelay3;
    public GameObject bridgedelay4;
    public GameObject bridgedelay5;
    public GameObject bridgedelay6;


    public GameObject textBox2; //checkpointtext1//
    public GameObject checkpointtext2;
    public GameObject checkpointtext3;
    public GameObject checkpointtext4;
    public GameObject checkpointtext5;
    public GameObject checkpointtext6;
    public GameObject checkpointtext6q2;
    public GameObject checkpointtext6q3;
    public GameObject checkpointtext9;
    public GameObject checkpointtext10;
    public GameObject checkpointtext11;
    public GameObject checkpointtext12;
    public GameObject checkpointtext13;
    public GameObject checkpointtext14;
    public GameObject checkpointtext15;
    public Text theText2;
    public TextAsset textFile2;
    public string[] textLines2;
    public Canvas finish;
    public Canvas finish2;
    public Canvas finish3;
    public Canvas checkq;
    public GameObject cubecheck;
    public GameObject cubecheck2;
    public GameObject cubecheck3;
    public GameObject cubecheck4;
    public GameObject cubecheck5;
    public GameObject cubecheck6;
    public GameObject cubecheck6q2;
    public GameObject cubecheck6q3;
    public GameObject cubecheck10;
    public GameObject cubecheck11;
    public GameObject cubecheck12;
    public GameObject cubecheck13;
    public GameObject cubecheckgoal;


    public bool isActive;

    public static int levelN = 0;
    

    private Vector3 startPos;
    private Quaternion startRot;

    public AudioSource soundcheckpoint;

    // Use this for initialization
    void Start()
    {
        countex = 0;
        countexam.text = "บทที่ : " + countex.ToString()+"/15";
        countscore = GameObject.FindGameObjectWithTag("Player").GetComponent<score>();

        blur.enabled = false;

        startPos = transform.position;
        startRot = transform.rotation;
        textBox2.SetActive(false);
        checkpointtext2.SetActive(false);
        checkpointtext3.SetActive(false);
        checkpointtext4.SetActive(false);
        checkpointtext5.SetActive(false);
        checkpointtext6.SetActive(false);
        checkpointtext6q2.SetActive(false);
        checkpointtext6q3.SetActive(false);
        checkpointtext9.SetActive(false);
        checkpointtext10.SetActive(false);
        checkpointtext11.SetActive(false);
        checkpointtext12.SetActive(false);
        checkpointtext13.SetActive(false);
        checkpointtext14.SetActive(false);
        checkpointtext15.SetActive(false);
        finish = finish.GetComponent<Canvas>();
        finish.enabled = false;
        finish2.enabled = false;
        finish3.enabled = false;
        checkq.enabled = false;
        cubecheck.SetActive(false);
        cubecheck2.SetActive(false);
        cubecheck3.SetActive(false);
        cubecheck4.SetActive(false);
        cubecheck5.SetActive(false);
        cubecheck6.SetActive(false);
        cubecheck6q2.SetActive(false);
        cubecheck6q3.SetActive(false);
        cubecheck10.SetActive(false);
        cubecheck11.SetActive(false);
        cubecheck12.SetActive(false);
        cubecheck13.SetActive(false);
        cubecheckgoal.SetActive(false);



    }

    

    void Update()
    {
        if (!isActive)
        {
            return;
        }
        
     
    }

    //detect collistion with trigger//
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "death")
        {

            transform.position = startPos;
            transform.rotation = startRot;
            GetComponent<Animator>().Play("LOSE00", -1, 0f);
            GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
            
        }

        else if (col.tag == "fakebridge")
        {
            fakebridge.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge2")
        {
            fakebridge2.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge3")
        {
            fakebridge3.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge4")
        {
            fakebridge4.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge5")
        {
            fakebridge5.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge6")
        {
            fakebridge6.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge7")
        {
            fakebridge7.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge8")
        {
            fakebridge8.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge9")
        {
            fakebridge9.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge10")
        {
            fakebridge10.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge11")
        {
            fakebridge11.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge12")
        {
            fakebridge12.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge13")
        {
            fakebridge13.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge14")
        {
            fakebridge14.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge15")
        {
            fakebridge15.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge16")
        {
            fakebridge16.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge17")
        {
            fakebridge17.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge18")
        {
            fakebridge18.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge19")
        {
            fakebridge19.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge20")
        {
            fakebridge20.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge21")
        {
            fakebridge21.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge22")
        {
            fakebridge22.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge23")
        {
            fakebridge23.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge24")
        {
            fakebridge24.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge25")
        {
            fakebridge25.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge26")
        {
            fakebridge26.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge27")
        {
            fakebridge27.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge28")
        {
            fakebridge28.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge29")
        {
            fakebridge29.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge30")
        {
            fakebridge30.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge31")
        {
            fakebridge31.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge32")
        {
            fakebridge32.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge33")
        {
            fakebridge33.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge34")
        {
            fakebridge34.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge35")
        {
            fakebridge35.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge36")
        {
            fakebridge36.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge37")
        {
            fakebridge37.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge38")
        {
            fakebridge38.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge39")
        {
            fakebridge39.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge40")
        {
            fakebridge40.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge41")
        {
            fakebridge41.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge42")
        {
            fakebridge42.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge43")
        {
            fakebridge43.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge44")
        {
            fakebridge44.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge45")
        {
            fakebridge45.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge46")
        {
            fakebridge46.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge47")
        {
            fakebridge47.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge48")
        {
            fakebridge48.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge49")
        {
            fakebridge49.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge50")
        {
            fakebridge50.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge51")
        {
            fakebridge51.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge52")
        {
            fakebridge52.SetActive(false);
            fakebridgesound.Play();
        }
        else if (col.tag == "fakebridge53")
        {
            fakebridge53.SetActive(false);
            fakebridgesound.Play();
        }

        else if (col.tag == "bridgedelay1")
        {
            Invoke("delaybridge1", 3f);
        }
        else if (col.tag == "bridgedelay2")
        {
            Invoke("delaybridge2", 3f);
        }
        else if (col.tag == "bridgedelay3")
        {
            Invoke("delaybridge3", 3f);
        }
        else if (col.tag == "bridgedelay4")
        {
            Invoke("delaybridge4", 3f);
        }
        else if (col.tag == "bridgedelay5")
        {
            Invoke("delaybridge5", 3f);
        }
        else if (col.tag == "bridgedelay6")
        {
            Invoke("delaybridge6", 3f);
        }

        else if (col.tag == "checkpoint")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            textBox2.SetActive(true);
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
            soundcheckpoint.Play();
            
        }

        else if (col.tag == "checkpoint2")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext2.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint3")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext3.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint4")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext4.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint5")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext5.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        
        else if (col.tag == "checkpoint6")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext6.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint6q2")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext6q2.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint6q3")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext6q3.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint9")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext9.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint10")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext10.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint11")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext11.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint12")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext12.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint13")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext13.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint14")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext14.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }
        else if (col.tag == "checkpoint15")
        {
            countex = countex + 1;
            countexam.text = "บทที่ : " + countex.ToString() + "/15";
            blur.enabled = true;
            checkpointtext15.SetActive(true);
            soundcheckpoint.Play();
            Time.timeScale = 0;
            startPos = col.transform.position;
            startRot = col.transform.rotation;
            Destroy(col.gameObject);
        }

        else if (col.tag == "goal")
        {
            Destroy(col.gameObject);
            if (countscore.count >= 4180)//full 5220//
            {
                soundcheckpoint.Play();
                blur.enabled = true;
                Time.timeScale = 0;
                finish3.enabled = true;
                scorecountend.text = "คะแนน  :  " + countscore.count.ToString();
            }
            else if (countscore.count <=4179)
            {
                if (countscore.count >= 2610) {
                    soundcheckpoint.Play();
                    blur.enabled = true;
                    Time.timeScale = 0;
                    finish2.enabled = true;
                    scorecountend2.text = "คะแนน  :  " + countscore.count.ToString();
                }

            }
            else if (countscore.count <= 2609)
            {
                soundcheckpoint.Play();
                blur.enabled = true;
                Time.timeScale = 0;
                finish.enabled = true;
                scorecountend3.text = "คะแนน  :  " + countscore.count.ToString();
            }

        }
        


    }

    void delaybridge1()
    {
        bridgedelay1.SetActive(false);
        fakebridgesound.Play();
        Invoke("delaypopup", 1f);
    }
    void delaypopup()
    {
        bridgedelay1.SetActive(true);
    }

    void delaybridge2()
    {
        bridgedelay2.SetActive(false);
        fakebridgesound.Play();
        Invoke("delaypopup2", 1f);
    }
    void delaypopup2()
    {
        bridgedelay2.SetActive(true);
    }

    void delaybridge3()
    {
        bridgedelay3.SetActive(false);
        fakebridgesound.Play();
        Invoke("delaypopup3", 1f);
    }
    void delaypopup3()
    {
        bridgedelay3.SetActive(true);
    }

    void delaybridge4()
    {
        bridgedelay4.SetActive(false);
        fakebridgesound.Play();
        Invoke("delaypopup4", 1f);
    }
    void delaypopup4()
    {
        bridgedelay4.SetActive(true);
    }
    void delaybridge5()
    {
        bridgedelay5.SetActive(false);
        fakebridgesound.Play();
        Invoke("delaypopup5", 1f);
    }
    void delaypopup5()
    {
        bridgedelay5.SetActive(true);
    }
    void delaybridge6()
    {
        bridgedelay6.SetActive(false);
        fakebridgesound.Play();
        Invoke("delaypopup6", 1f);
    }
    void delaypopup6()
    {
        bridgedelay6.SetActive(true);
    }

}
