using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class characterselection : MonoBehaviour {

    private GameObject[] characterlist;
    private int index;


    private void Start()
    {

        index = PlayerPrefs.GetInt("select");

        characterlist = new GameObject[transform.childCount];

       for(int i =0; i< transform.childCount; i++)
            characterlist[i] = transform.GetChild(i).gameObject;

       foreach ( GameObject go in characterlist)
            go.SetActive(false);

        if (characterlist[index])
            characterlist[index].SetActive(true);

    }

    public void left()
    {

        characterlist[index].SetActive(false);

        index--;
        if (index < 0)
            index = characterlist.Length - 1;
        characterlist[index].SetActive(true);
    }

    public void right()
    {

        characterlist[index].SetActive(false);

        index++;
        if (index == characterlist.Length)
            index = 0;
        characterlist[index].SetActive(true);
    }

    public void confirm()
    {
        PlayerPrefs.SetInt("select", index);
        SceneManager.LoadScene("movie2");
    }

}
