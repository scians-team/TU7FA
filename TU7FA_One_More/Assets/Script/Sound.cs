using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Sound : MonoBehaviour {
    public static  AudioSource src;
    public AudioClip clip;

	// Use this for initialization

    void Awake()
    {


        DontDestroyOnLoad();

    }

    private void DontDestroyOnLoad()
    {
        throw new System.NotImplementedException();
    }
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
