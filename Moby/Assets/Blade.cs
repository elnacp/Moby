using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour {


    bool isCutting = false;

    Rigidbody2D rb;
    Camera cam;


	private void Start()
	{

        cam = Camera.main; 
        rb = GetComponent<Rigidbody2D>();

	}



	// Update is called once per frame
	void Update () {
		


        /*
        if( Input.GetMouseButtonDown(0)){
            StartCutting();
        }else if(Input.GetMouseButtonUp(0)){
            StopCutting();
        }*/


        if(Input.touchCount > 0){
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                StartCutting();
            }
            if(Input.GetTouch(0).phase == TouchPhase.Moved){
                if(isCutting){
                    UpdateCut();
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                StopCutting();
            }
        }






	}


    void UpdateCut(){
        rb.position = cam.ScreenToWorldPoint(Input.GetTouch(0).position);
        Debug.Log("Rb:" +rb.position);

    }

    void StartCutting(){
        isCutting = true;
    }

    void StopCutting(){
        isCutting = false;
    }


}
