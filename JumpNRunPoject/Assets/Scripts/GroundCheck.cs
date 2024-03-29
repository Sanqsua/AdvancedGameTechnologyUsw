﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {
    private Player player;
	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<Player>();
	}

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.grounded = true;
        player.jumpcount = 0;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        player.grounded = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        player.grounded = false;
        player.jumpcount = 1;
    }
}
