using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideModel : MonoBehaviour {
    public GameObject CL1;
    public GameObject CL2;
    public GameObject CL3;
    public GameObject CL4;
    public GameObject CL5;
    public GameObject CL6;
    public GameObject CL7;
    public GameObject CL8;
    public GameObject CL9;



    public GameObject WL1;
    public GameObject WL2;
    public GameObject WL3;
    public GameObject WL4;
    public GameObject WL5;
    public GameObject WL6;
    public GameObject WL7;
    public GameObject WL8;
    public GameObject WL9;

    public GameObject TL1;
    public GameObject TL2;
    public GameObject TL3;
    public GameObject TL4;
    public GameObject TL5;
    public GameObject TL6;
    public GameObject TL7;
    public GameObject TL8;
    public GameObject TL9;

	// Use this for initialization
	void Start () {
        CL1.SetActive(false);
        CL2.SetActive(false);
        CL3.SetActive(false);
        CL4.SetActive(false);
        CL5.SetActive(false);
        CL6.SetActive(false);
        CL7.SetActive(false);
        CL8.SetActive(false);
        CL9.SetActive(false);

        WL1.SetActive(false);
        WL2.SetActive(false);
        WL3.SetActive(false);
        WL4.SetActive(false);
        WL5.SetActive(false);
        WL6.SetActive(false);
        WL7.SetActive(false);
        WL8.SetActive(false);
        WL9.SetActive(false);

        TL1.SetActive(false);
        TL2.SetActive(false);
        TL3.SetActive(false);
        TL4.SetActive(false);
        TL5.SetActive(false);
        TL6.SetActive(false);
        TL7.SetActive(false);
        TL8.SetActive(false);
        TL9.SetActive(false);
       
		
	}
	
	// Update is called once per frame
	

    public void ceilingClick()
    {
        CL1.SetActive(true);
        CL2.SetActive(true);
        CL3.SetActive(true);
        CL4.SetActive(true);
        CL5.SetActive(true);
        CL6.SetActive(true);
        CL7.SetActive(true);
        CL8.SetActive(true);
        CL9.SetActive(true);

        WL1.SetActive(false);
        WL2.SetActive(false);
        WL3.SetActive(false);
        WL4.SetActive(false);
        WL5.SetActive(false);
        WL6.SetActive(false);
        WL7.SetActive(false);
        WL8.SetActive(false);
        WL9.SetActive(false);

        TL1.SetActive(false);
        TL2.SetActive(false);
        TL3.SetActive(false);
        TL4.SetActive(false);
        TL5.SetActive(false);
        TL6.SetActive(false);
        TL7.SetActive(false);
        TL8.SetActive(false);
        TL9.SetActive(false);
       



    }
    
    public void wellClick()
    {


        CL1.SetActive(false);
        CL2.SetActive(false);
        CL3.SetActive(false);
        CL4.SetActive(false);
        CL5.SetActive(false);
        CL6.SetActive(false);
        CL7.SetActive(false);
        CL8.SetActive(false);
        CL9.SetActive(false);

        WL1.SetActive(true);
        WL2.SetActive(true);
        WL3.SetActive(true);
        WL4.SetActive(true);
        WL5.SetActive(true);
        WL6.SetActive(true);
        WL7.SetActive(true);
        WL8.SetActive(true);
        WL9.SetActive(true);

        TL1.SetActive(false);
        TL2.SetActive(false);
        TL3.SetActive(false);
        TL4.SetActive(false);
        TL5.SetActive(false);
        TL6.SetActive(false);
        TL7.SetActive(false);
        TL8.SetActive(false);
        TL9.SetActive(false);
       
      

    }


    public void tableClick()
    {


        CL1.SetActive(false);
        CL2.SetActive(false);
        CL3.SetActive(false);
        CL4.SetActive(false);
        CL5.SetActive(false);
        CL6.SetActive(false);
        CL7.SetActive(false);
        CL8.SetActive(false);
        CL9.SetActive(false);

        WL1.SetActive(false);
        WL2.SetActive(false);
        WL3.SetActive(false);
        WL4.SetActive(false);
        WL5.SetActive(false);
        WL6.SetActive(false);
        WL7.SetActive(false);
        WL8.SetActive(false);
        WL9.SetActive(false);

        TL1.SetActive(true);
        TL2.SetActive(true);
        TL3.SetActive(true);
        TL4.SetActive(true);
        TL5.SetActive(true);
        TL6.SetActive(true);
        TL7.SetActive(true);
        TL8.SetActive(true);
        TL9.SetActive(true);




    }
    

}
