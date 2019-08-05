using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Objects1 : MonoBehaviour {
    public GameObject obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8,obj9;

	// Use this for initialization
	void Start () {

        int p = PlayerPrefs.GetInt("num");
        switch (p)
        {
            case 1:
                obj1.SetActive(true);
                break;
            case 2:
                obj2.SetActive(true);
                break;
            case 3:
                obj3.SetActive(true);
                break;
            case 4:
                obj4.SetActive(true);
                break;
            case 5:
                obj5.SetActive(true);
                break;
            case 6:
                obj6.SetActive(true);
                break;
            case 7:
                obj7.SetActive(true);
                break;
            case 8:
                obj8.SetActive(true);
                break;
            case 9:
                obj9.SetActive(true);
                break;
            

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
