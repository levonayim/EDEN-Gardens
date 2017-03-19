using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeExit : MonoBehaviour {

    public GameObject sib;


    // Use this for initialization
    void Start()
    {
        print("menu: start");
        print(sib);
    }

    // Update is called once per frame
    void Update()
    {
        print("menu: update");

        //if child is not enabled, deactivate self
        if (!sib.activeSelf)
        {
            print("menu: deactivate");

            //not just the game object: the menu and the plane
            gameObject.SetActive(false);
        }

    }
}
