using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_manager : MonoBehaviour {

	public static Game_manager instance = null;
	public GameObject spawnPoint;
	public GameObject[] enemies;
	public int maxEnemiesOnScreen;
	public int totalEnemies;
	public int enemiesPerSpawn;

	private int enemiesOnscreen = 0;
	const float spawn_delay = 0.5f;
	
	void Awake() {
		if (instance == null) 
			instance = this;
		
		 else if (instance != this)
			Destroy (gameObject);
		
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
		//spawn_enemy ();	
		StartCoroutine 	(spawn());
	}
	
	/*void spawn_enemy() {
		if (enemiesPerSpawn > 0 && enemiesOnscreen < totalEnemies) {
			for (int i = 0; i < enemiesPerSpawn; i++) {
				if (enemiesOnscreen < maxEnemiesOnScreen) {
					GameObject newEnemy = Instantiate (enemies [0] as GameObject);
					newEnemy.transform.position = spawnPoint.transform.position;
					enemiesOnscreen += 1;
				
				}
			
			}
		}
	
	}*/

	IEnumerator spawn() {
		if (enemiesPerSpawn > 0 && enemiesOnscreen < totalEnemies) {
			for (int i = 0; i < enemiesPerSpawn; i++) {
				if (enemiesOnscreen < maxEnemiesOnScreen) {
					GameObject newEnemy = Instantiate (enemies [0] as GameObject);
					newEnemy.transform.position = spawnPoint.transform.position;
					enemiesOnscreen += 1;

				}

			}
			yield return new WaitForSeconds (spawn_delay);
			StartCoroutine (spawn ());
		}
	
	}

	public void removeEnemyFromScreen() {
		if (enemiesOnscreen > 0) { 
			enemiesOnscreen -= 1;
	
		}
	}
}
