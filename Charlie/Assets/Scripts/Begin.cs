using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Begin : MonoBehaviour {
    public AudioSource source;
    public AudioClip hover;
    public AudioClip down;
    

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void StartScreen()
    {
        EditorSceneManager.LoadScene(1);
    }

    public void OnHover()
    {
        source.PlayOneShot(hover);

    }

    public void OnDown()
    {
        source.PlayOneShot(down);

    }
}


