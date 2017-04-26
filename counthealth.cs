using UnityEngine;
using System.Collections;

public class counthealth : MonoBehaviour {

    private health player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<health>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "death")
        {
            player.damage(1);
        }
    }

}
