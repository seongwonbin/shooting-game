using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSc : MonoBehaviour {

    

    public Slider healthBarSlider;  //reference for slider
    public Text gameOverText;   //reference for text
    public bool isGameOver = false; //flag to see if game is over


    
	// Use this for initialization
	void Start () {
        gameOverText.enabled = false; //disable GameOver text on start

    

    }
	
	// Update is called once per frame
	void Update () {
        if (!isGameOver)
            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10f, 0, 0); //get input


    

    }
    void OnTriggerStay(Collider other)
    {
        //if player triggers fire object and health is greater than 0
        if (other.gameObject.tag == "Enemy_Tag" && healthBarSlider.value > 0)
        {
            healthBarSlider.value -= 0.7f;  //reduce health
        }
        
        else
        {
            isGameOver = true;    //set game over to true
            gameOverText.enabled = true; //enable GameOver text
          
        }

        if (isGameOver)
            Time.timeScale = 0;
        
    }


  
}
