using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;


public class play : MonoBehaviour {
    public GameObject menu;

    void Start()
    {
        print("play: start game");
     }

    void Update()
    {
        print("play: update");
        gameObject.SetActive(true);
    }
    //link the main menu to this method to turn it off
    void OnMouseDown()
    {
        //in the event of mouse being clicked
        //debug log: play button 
        print("play: mouse down");

        //not just the game object: the menu and the plane
        gameObject.SetActive(false);
        return;
    }




}
