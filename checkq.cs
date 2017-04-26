using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class checkq : MonoBehaviour {

    
    public Canvas checkques;
    public Canvas checkques2;
    public Canvas checkques3;
    public Canvas checkques4;
    public Canvas checkques5;
    public Canvas checkques6;
    public Canvas checkques6q2;
    public Canvas checkques6q3;
    public Canvas checkques9;
    public Canvas checkques10;
    public Canvas checkques11;
    public Canvas checkques12;
    public Canvas checkques13;
    public Canvas checkques14;
    public Canvas checkques15;
    public Button exambutton;
    public Button exambutton2;
    public Button exambutton3;
    public Button exambutton4;
    public Button exambutton5;
    public Button exambutton6;
    public Button exambutton6q2;
    public Button exambutton6q3;
    public Button exambutton9;
    public Button exambutton10;
    public Button exambutton11;
    public Button exambutton12;
    public Button exambutton13;
    public Button exambutton14;
    public Button exambutton15;
    public GameObject checkstory;
    public GameObject checkstory2;
    public GameObject checkstory3;
    public GameObject checkstory4;
    public GameObject checkstory5;
    public GameObject checkstory6;
    public GameObject checkstory6q2;
    public GameObject checkstory6q3;
    public GameObject checkstory9;
    public GameObject checkstory10;
    public GameObject checkstory11;
    public GameObject checkstory12;
    public GameObject checkstory13;
    public GameObject checkstory14;
    public GameObject checkstory15;
    public GameObject spawncheckcube;
    public GameObject spawncheckcube2;
    public GameObject spawncheckcube3;
    public GameObject spawncheckcube4;
    public GameObject spawncheckcube5;
    public GameObject spawncheckcube6;
    public GameObject spawncheckcube6q2;
    public GameObject spawncheckcube6q3;
    public GameObject spawncheckcube9;
    public GameObject spawncheckcube10;
    public GameObject spawncheckcube11;
    public GameObject spawncheckcube12;
    public GameObject spawncheckcube13;
    public GameObject spawncheckcube14;
    public GameObject spawncheckcube15;
    public Canvas questionistrue;
    public Canvas questionisfalse;
    public Canvas questionistrue2;
    public Canvas questionisfalse2;
    public Canvas questionistrue3;
    public Canvas questionisfalse3;
    public Canvas questionistrue4;
    public Canvas questionisfalse4;
    public Canvas questionistrue5;
    public Canvas questionisfalse5;
    public Canvas questionistrue6;
    public Canvas questionisfalse6;
    public Canvas questionistrue6q2;
    public Canvas questionisfalse6q2;
    public Canvas questionistrue6q3;
    public Canvas questionisfalse6q3;
    public Canvas questionistrue9;
    public Canvas questionisfalse9;
    public Canvas questionistrue10;
    public Canvas questionisfalse10;
    public Canvas questionistrue11;
    public Canvas questionisfalse11;
    public Canvas questionistrue12;
    public Canvas questionisfalse12;
    public Canvas questionistrue13;
    public Canvas questionisfalse13;
    public Canvas questionistrue14;
    public Canvas questionisfalse14;
    public Canvas questionistrue15;
    public Canvas questionisfalse15;

    public Canvas blur;

    public AudioSource soundclick;
    private AudioSource trueclick;
    
    private health damage;

    private score answer;

    // Use this for initialization
    void Start () {

        answer = GameObject.FindGameObjectWithTag("Player").GetComponent<score>();

        trueclick = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();

        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<health>();

        blur.enabled = false;
       
        checkques.enabled = false;
        checkques2.enabled = false;
        checkques3.enabled = false;
        checkques4.enabled = false;
        checkques5.enabled = false;
        checkques6.enabled = false;
        checkques6q2.enabled = false;
        checkques6q3.enabled = false;
        checkques9.enabled = false;
        checkques10.enabled = false;
        checkques11.enabled = false;
        checkques12.enabled = false;
        checkques13.enabled = false;
        checkques14.enabled = false;
        checkques15.enabled = false;
        questionistrue.enabled = false;
        questionisfalse.enabled = false;
        questionistrue2.enabled = false;
        questionisfalse2.enabled = false;
        questionistrue3.enabled = false;
        questionisfalse3.enabled = false;
        questionistrue4.enabled = false;
        questionisfalse4.enabled = false;
        questionistrue5.enabled = false;
        questionisfalse5.enabled = false;
        questionistrue6.enabled = false;
        questionisfalse6.enabled = false;
        questionistrue6q2.enabled = false;
        questionisfalse6q2.enabled = false;
        questionistrue6q3.enabled = false;
        questionisfalse6q3.enabled = false;
        questionistrue9.enabled = false;
        questionisfalse9.enabled = false;
        questionistrue10.enabled = false;
        questionisfalse10.enabled = false;
        questionistrue11.enabled = false;
        questionisfalse11.enabled = false;
        questionistrue12.enabled = false;
        questionisfalse12.enabled = false;
        questionistrue13.enabled = false;
        questionisfalse13.enabled = false;
        questionistrue14.enabled = false;
        questionisfalse14.enabled = false;
        questionistrue15.enabled = false;
        questionisfalse15.enabled = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            questionistrue.enabled = false;
            questionistrue2.enabled = false;
            questionistrue3.enabled = false;
            questionistrue4.enabled = false;
            questionistrue5.enabled = false;
            questionistrue6.enabled = false;
            questionistrue6q2.enabled = false;
            questionistrue6q3.enabled = false;
            questionistrue9.enabled = false;
            questionistrue10.enabled = false;
            questionistrue11.enabled = false;
            questionistrue12.enabled = false;
            questionistrue13.enabled = false;
            questionistrue14.enabled = false;
            questionistrue15.enabled = false;


        }
    }

    
	
	public void checkquestion()
    {
        checkques.enabled = true;
        checkstory.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion2()
    {
        checkques2.enabled = true;
        checkstory2.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion3()
    {
        checkques3.enabled = true;
        checkstory3.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion4()
    {
        checkques4.enabled = true;
        checkstory4.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion5()
    {
        checkques5.enabled = true;
        checkstory5.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion6()
    {
        checkques6.enabled = true;
        checkstory6.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion6q2()
    {
        checkques6q2.enabled = true;
        checkstory6q2.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion6q3()
    {
        checkques6q3.enabled = true;
        checkstory6q3.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion9()
    {
        checkques9.enabled = true;
        checkstory9.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion10()
    {
        checkques10.enabled = true;
        checkstory10.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion11()
    {
        checkques11.enabled = true;
        checkstory11.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion12()
    {
        checkques12.enabled = true;
        checkstory12.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion13()
    {
        checkques13.enabled = true;
        checkstory13.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion14()
    {
        checkques14.enabled = true;
        checkstory14.SetActive(false);
        soundclick.Play();
    }
    public void checkquestion15()
    {
        checkques15.enabled = true;
        checkstory15.SetActive(false);
        soundclick.Play();
    }

    public void questiontrue()
    {
        checkques.enabled = false;
        spawncheckcube.SetActive(true);
        questionistrue.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue2()
    {
        checkques2.enabled = false;
        spawncheckcube2.SetActive(true);
        
        questionistrue2.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue3()
    {
        checkques3.enabled = false;
        spawncheckcube3.SetActive(true);
        
        questionistrue3.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue4()
    {
        checkques4.enabled = false;
        spawncheckcube4.SetActive(true);
        questionistrue4.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue5()
    {
        checkques5.enabled = false;
        spawncheckcube5.SetActive(true);
        questionistrue5.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue6()
    {
        checkques6.enabled = false;
        spawncheckcube6.SetActive(true);
        questionistrue6.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue6q2()
    {
        checkques6q2.enabled = false;
        spawncheckcube6q2.SetActive(true);
        questionistrue6q2.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue6q3()
    {
        checkques6q3.enabled = false;
        spawncheckcube6q3.SetActive(true);
        questionistrue6q3.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue9()
    {
        checkques9.enabled = false;
        spawncheckcube9.SetActive(true);
        questionistrue9.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue10()
    {
        checkques10.enabled = false;
        spawncheckcube10.SetActive(true);
        questionistrue10.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue11()
    {
        checkques11.enabled = false;
        spawncheckcube11.SetActive(true);
        questionistrue11.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue12()
    {
        checkques12.enabled = false;
        spawncheckcube12.SetActive(true);
        questionistrue12.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue13()
    {
        checkques13.enabled = false;
        spawncheckcube13.SetActive(true);
        questionistrue13.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue14()
    {
        checkques14.enabled = false;
        spawncheckcube14.SetActive(true);
        questionistrue14.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }
    public void questiontrue15()
    {
        checkques15.enabled = false;
        spawncheckcube15.SetActive(true);
        questionistrue15.enabled = true;
        trueclick.Play();
        damage.curHealth = 5;
        Time.timeScale = 1;
        blur.enabled = false;
        answer.trueanswer(100);
    }

    public void questionfalse()
    {
        questionisfalse.enabled = true;
        checkques.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);

    }
    public void questionfalse2()
    {
        questionisfalse2.enabled = true;
        checkques2.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse3()
    {
        questionisfalse3.enabled = true;
        checkques3.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse4()
    {
        questionisfalse4.enabled = true;
        checkques4.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse5()
    {
        questionisfalse5.enabled = true;
        checkques5.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse6()
    {
        questionisfalse6.enabled = true;
        checkques6.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse6q2()
    {
        questionisfalse6q2.enabled = true;
        checkques6q2.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse6q3()
    {
        questionisfalse6q3.enabled = true;
        checkques6q3.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse9()
    {
        questionisfalse9.enabled = true;
        checkques9.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse10()
    {
        questionisfalse10.enabled = true;
        checkques10.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse11()
    {
        questionisfalse11.enabled = true;
        checkques11.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse12()
    {
        questionisfalse12.enabled = true;
        checkques12.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse13()
    {
        questionisfalse13.enabled = true;
        checkques13.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse14()
    {
        questionisfalse14.enabled = true;
        checkques14.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }
    public void questionfalse15()
    {
        questionisfalse15.enabled = true;
        checkques15.enabled = false;
        GetComponent<AudioSource>().Play();
        damage.damage(1);
        answer.falseanswer(50);
    }

    public void backread()
    {
        checkstory.SetActive(true);
        questionisfalse.enabled = false;
        soundclick.Play();
    }
    public void backread2()
    {
        checkstory2.SetActive(true);
        questionisfalse2.enabled = false;
        soundclick.Play();
    }
    public void backread3()
    {
        checkstory3.SetActive(true);
        questionisfalse3.enabled = false;
        soundclick.Play();
    }
    public void backread4()
    {
        checkstory4.SetActive(true);
        questionisfalse4.enabled = false;
        soundclick.Play();
    }
    public void backread5()
    {
        checkstory5.SetActive(true);
        questionisfalse5.enabled = false;
        soundclick.Play();
    }
    public void backread6()
    {
        checkstory6.SetActive(true);
        questionisfalse6.enabled = false;
        soundclick.Play();
    }
    public void backread6q2()
    {
        checkstory6q2.SetActive(true);
        questionisfalse6q2.enabled = false;
        soundclick.Play();
    }
    public void backread6q3()
    {
        checkstory6q3.SetActive(true);
        questionisfalse6q3.enabled = false;
        soundclick.Play();
    }
    public void backread9()
    {
        checkstory9.SetActive(true);
        questionisfalse9.enabled = false;
        soundclick.Play();
    }
    public void backread10()
    {
        checkstory10.SetActive(true);
        questionisfalse10.enabled = false;
        soundclick.Play();
    }
    public void backread11()
    {
        checkstory11.SetActive(true);
        questionisfalse11.enabled = false;
        soundclick.Play();
    }
    public void backread12()
    {
        checkstory12.SetActive(true);
        questionisfalse12.enabled = false;
        soundclick.Play();
    }
    public void backread13()
    {
        checkstory13.SetActive(true);
        questionisfalse13.enabled = false;
        soundclick.Play();
    }
    public void backread14()
    {
        checkstory14.SetActive(true);
        questionisfalse14.enabled = false;
        soundclick.Play();
    }
    public void backread15()
    {
        checkstory15.SetActive(true);
        questionisfalse14.enabled = false;
        soundclick.Play();
    }

    public void backexam()
    {
        checkques.enabled = true;
        questionisfalse.enabled = false;
        soundclick.Play();
    }
    public void backexam2()
    {
        checkques2.enabled = true;
        questionisfalse2.enabled = false;
        soundclick.Play();
    }
    public void backexam3()
    {
        checkques3.enabled = true;
        questionisfalse3.enabled = false;
        soundclick.Play();
    }
    public void backexam4()
    {
        checkques4.enabled = true;
        questionisfalse4.enabled = false;
        soundclick.Play();
    }
    public void backexam5()
    {
        checkques5.enabled = true;
        questionisfalse5.enabled = false;
        soundclick.Play();
    }
    public void backexam6()
    {
        checkques6.enabled = true;
        questionisfalse6.enabled = false;
        soundclick.Play();
    }
    public void backexam6q2()
    {
        checkques6q2.enabled = true;
        questionisfalse6q2.enabled = false;
        soundclick.Play();
    }
    public void backexam6q3()
    {
        checkques6q3.enabled = true;
        questionisfalse6q3.enabled = false;
        soundclick.Play();
    }
    public void backexam9()
    {
        checkques9.enabled = true;
        questionisfalse9.enabled = false;
        soundclick.Play();
    }
    public void backexam10()
    {
        checkques10.enabled = true;
        questionisfalse10.enabled = false;
        soundclick.Play();
    }
    public void backexam11()
    {
        checkques11.enabled = true;
        questionisfalse11.enabled = false;
        soundclick.Play();
    }
    public void backexam12()
    {
        checkques12.enabled = true;
        questionisfalse12.enabled = false;
        soundclick.Play();
    }
    public void backexam13()
    {
        checkques13.enabled = true;
        questionisfalse13.enabled = false;
        soundclick.Play();
    }
    public void backexam14()
    {
        checkques14.enabled = true;
        questionisfalse14.enabled = false;
        soundclick.Play();
    }
    public void backexam15()
    {
        checkques15.enabled = true;
        questionisfalse15.enabled = false;
        soundclick.Play();
    }
    

}
