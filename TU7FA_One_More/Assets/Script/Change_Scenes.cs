using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Main_Scene_Cick()
    {

        SceneManager.LoadScene("Main");

    }
    public void Objects_Scene_Cick()
    {

        SceneManager.LoadScene("Object_Scenes");

    }
    public void About_Scene_Cick()
    {

        SceneManager.LoadScene("About_Scene");

    }

}
