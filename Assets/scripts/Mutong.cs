﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mutong : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void water(Vector3 pos){
		print ("water");
		ArrayList pits = PitManager.pits;
		for (int i = 0; i < pits.Count; i++) {
			PitManager.Pit pit = (PitManager.Pit)pits [i];
			if (pit.InIt (pos)) {
				if (pit.hasSeed) {
					pit.GrowFlower ();
					pits.RemoveAt (i);
				}
				break;
			}
		}
	}
	public void grow(GameObject flower){
		watermelon script=flower.GetComponent<watermelon>();
		if (script.Stage == 1) {
			script.GrowUp ();
		}
	}
}
