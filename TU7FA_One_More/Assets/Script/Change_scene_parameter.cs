using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Change_scene_parameter : MonoBehaviour {
	// Use this for initialization
    public void change1()
    {
        PlayerPrefs.SetInt("num", 1);

    }
    public void change2()
    {
        PlayerPrefs.SetInt("num", 2);

    }
    public void change3()
    {
        PlayerPrefs.SetInt("num", 3);

    }
    public void change4()
    {
        PlayerPrefs.SetInt("num", 4);

    }
    public void change5()
    {
        PlayerPrefs.SetInt("num", 5);

    }
    public void change6()
    {
        PlayerPrefs.SetInt("num", 6);

    }
    public void change7()
    {
        PlayerPrefs.SetInt("num", 7);

    }
    public void change8()
    {
        PlayerPrefs.SetInt("num", 8);

    }
    public void change9()
    {
        PlayerPrefs.SetInt("num", 9);

    }

    public void change_scene1()
    {

        SceneManager.LoadScene("Ceiling Lamps");
    }
    public void change_scene2()
    {

        SceneManager.LoadScene("Wall Lamps");

    }
    public void change_scene3()
    {

        SceneManager.LoadScene("Table Lamps");
    }
}
