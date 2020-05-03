using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour {


    private float z_trans;
    private float current_z_trans;


    // Use this for initialization
    void Start () {
        current_z_trans = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        float pos_result;

        z_trans -= 0.005f;
        pos_result = current_z_trans + z_trans * Time.deltaTime;
        transform.Translate(0.0f, 0.0f, z_trans);

        //Debug.Log(z_trans);

        if (pos_result < 0.0f)
        {
            Destroy(gameObject, 0);
        }
    }


}
