using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hud : MonoBehaviour {

    public Sprite[] heartsprites;
    public Image heartUI;

    private health player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<health>();
    }
	
    void Update()
    {
        heartUI.sprite = heartsprites[player.curHealth];
    }
}
