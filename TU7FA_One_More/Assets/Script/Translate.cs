using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour {

    
    public GameObject objtranslate;
    public float translateSpeed = 0.5f;
    bool translateStatus = false;

    public void trantasi()
    {

        if (translateStatus == false)
        {
            translateStatus = true;
        }
        else
        {
            translateStatus = false;
        }
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (translateStatus == true)
        {
            objtranslate.transform.Translate(x * translateSpeed, y * translateSpeed, 0);
        }
    }

}
