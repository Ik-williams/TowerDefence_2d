﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float navigationUpdate;
	public int target = 0;
	public Transform exitPoint; 
	public Transform[] wayPoints;


	private Transform enemy;
	private float navigationTime = 0;

	// Use this for initialization
	void Start () {
		enemy = GetComponent<Transform> ();	
	}
	
	// Update is called once per frame
	void Update () {

		if (wayPoints != null) {
			navigationTime += Time.deltaTime;
			if (navigationTime > navigationUpdate) {
				if (target < wayPoints.Length) {
					enemy.position = Vector2.MoveTowards (enemy.position, wayPoints [target].position, navigationTime);
				} else {
					enemy.position = Vector2.MoveTowards (enemy.position, exitPoint.position, navigationTime);
				
				}
				navigationTime = 0;
			
			}
		
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Checkpoint") {
			target += 1;
		} else if (other.tag == "Finish") {
			Game_manager.instance.removeEnemyFromScreen ();
			Destroy (gameObject);
		}
			
	}
}
