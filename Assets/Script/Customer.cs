using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Customer : MonoBehaviour {

   // Rigidbody2D rb;
    public static float WaitTime;

	void Start () {
		
        WaitTime = 10;
      //  rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        WaitTime -= 1f;

        if (WaitTime <= 0){
            // Player looses point 
        }
		
	}
}
