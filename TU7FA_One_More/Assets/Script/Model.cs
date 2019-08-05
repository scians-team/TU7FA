using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {

    public GameObject one1;
    public GameObject one2;
    public GameObject one3;

    public GameObject two1;
    

    // Use this for initialization
    void Start()
    {
        one1.SetActive(false);
        one2.SetActive(false);
        one3.SetActive(false);

        two1.SetActive(false);
        

    }

    // Update is called once per frame
   
    public void onAbagoraclick()
    {
        one1.SetActive(false);
        one2.SetActive(true);
        one3.SetActive(true);
        two1.SetActive(true);


    }

    public void onNgfclick()
    {

         one1.SetActive(true);
        one2.SetActive(false);
        one3.SetActive(false);
        two1.SetActive(false);
        


    }



}
