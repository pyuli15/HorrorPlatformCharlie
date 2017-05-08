using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {
    public float speed = 6;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.tag == "Player" && Input.GetKey(KeyCode.UpArrow))
        {
            coll.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (coll.tag =="Player" && Input.GetKey(KeyCode.DownArrow))
        {
            coll.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else
        {
            coll.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
        }
    }
}
