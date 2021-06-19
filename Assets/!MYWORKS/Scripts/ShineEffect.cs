using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShineEffect : MonoBehaviour {

    Animator an;
	// Use this for initialization
	void Start () {
        an = gameObject.GetComponent<Animator>();
        an.Play("Shiny");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
