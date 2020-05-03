using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Script : MonoBehaviour {


    public GameObject obj;
    private int counter;
    public SliderSc my_slider;

	// Use this for initialization
	void Start ()
    {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {

        ++counter;

        if (counter % 100 == 0)
        {

            for (int i = 0; i < 5; i++)
            {
                float randomX = Random.Range(-5, 5.0f);

                Instantiate(obj, new Vector3(randomX, 0.0f, 50.0f),Quaternion.identity);
            }
        }



    }
}
