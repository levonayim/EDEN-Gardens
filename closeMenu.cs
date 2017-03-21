//Created on: March 18, 2017
//Created by: Jessica Lieuson

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeMenu : MonoBehaviour {
    public GameObject child;


	// Use this for initialization
	void Start () {
        print("menu: start");
        print(child);
    }
	
	// Update is called once per frame
	void Update ()
    {
        print("menu: update");

        //if child is not enabled, deactivate self
        if (!child.activeSelf)
        {
            print("menu: deactivate");

            //not just the game object: the menu and the plane
            gameObject.SetActive(false);
        }

	}
}
