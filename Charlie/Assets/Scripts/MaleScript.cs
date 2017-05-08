using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaleScript : MonoBehaviour {

    Vector3 playerPos;
    Vector3 thisPos;
    GameObject player;
    public float speed;
    public AudioSource source;
    public AudioClip maleScream;
    public AudioClip background;
    public bool run;
    private bool hasPlayed;
    public GameObject splatter;
    



    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        run = false;
        source.PlayOneShot(background);
        


    }

    // Update is called once per frame
    void Update()
    {


        if (player != null)
        {
            playerPos = player.transform.position;


        }

        thisPos = transform.position;


        if (run == true)
        {

            Vector2 awayFromPlayer = thisPos + playerPos;
            transform.position += new Vector3(awayFromPlayer.x, awayFromPlayer.y, 0) * speed * Time.deltaTime;
            //transform.position = Vector2.Lerp(thisPos, -playerPos, Time.deltaTime * speed);

        }
    }

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            run = true;

            Destroy(gameObject);
            Instantiate(splatter, transform.position, transform.rotation);
            

            if (!hasPlayed)
            {
                
                source.PlayOneShot(maleScream);
                hasPlayed = true;
            }

        }



    }
    

}


