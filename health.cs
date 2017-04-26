using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour {

    public int curHealth;
    public int maxHealth = 5;
    

   
	
	void Start () {
        curHealth = maxHealth;
        
        
    }
	
	
	void Update () {
	
        if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if(curHealth <= 0)
        {
            die();
        }

	}

    void die()
    {
        Application.LoadLevel("gameover");
        
    }
    
    
    public void damage(int dmg)
    {
        curHealth -= dmg;
    }

    
  

}
