using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LoginScript : MonoBehaviour {
    private string u = "charlie";
    private string p = "woods";

    private string usernameString = string.Empty;
    private string passwordString = string.Empty;

    private Rect windowRect = new Rect(0, 0, Screen.width, Screen.height);
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnGUI()
    {
        GUI.Window(0, windowRect, WindowFunction, "Enter Case Username and Password");
    }

    void WindowFunction(int windowID)
    {
        usernameString = GUI.TextField(new Rect(Screen.width / 3, 2 * Screen.height / 5, Screen.width / 3, Screen.height / 10), usernameString, 10);
        passwordString = GUI.PasswordField(new Rect(Screen.width / 3, 2 * Screen.height / 3, Screen.width / 3, Screen.height / 10), passwordString, "*"[0], 10);

        if (GUI.Button(new Rect(Screen.width/2, 4* Screen.height/5, Screen.width/8, Screen.height/8),"Enter"))
        {
            if (usernameString == u && passwordString == p)
            {
                EditorSceneManager.LoadScene(2);
            }
            else { Debug.Log("Access Denied"); }
        }

       


    }
    public void Fail()
    {
        EditorSceneManager.LoadScene(0);
    }
}
