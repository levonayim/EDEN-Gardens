//Created on: March 18, 2017
//Created by: Jessica Lieuson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("exit: start");
    }
	
	// Update is called once per frame
	void Update () {
        print("exit: update");
    }
    void OnMouseDown()
    {
        //in the event of mouse being clicked
        //debug log: play button 
        print("exit: mouse down");

        //show goodbye message
            
        //End appllication
        Application.Quit();
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(5);
        print(Time.time);
    }

}
