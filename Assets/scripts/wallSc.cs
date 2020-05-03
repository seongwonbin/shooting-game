using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallSc : MonoBehaviour {

    private float z_diff;
    private float z_pos;
    public GameObject obj;


    // Use this for initialization
    void Start () {
        z_pos = 0.1f;
    }
	
	// Update is called once per frame
	void Update () {
       // z_pos += 0.1f;
       // transform.Translate(0.0f, 0.0f, z_pos * Time.deltaTime);

        Debug.Log(z_pos);

        if (z_pos > 40.0f)
        {

            Destroy(gameObject, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy_Tag")
        {
            Debug.Log("collision");
            Destroy(gameObject, 0);
            Destroy(other.gameObject, 0);
            Instantiate(obj, new Vector3(transform.position.x, transform.position.y, transform.position.z),
             Quaternion.identity);

        }
    }
}
