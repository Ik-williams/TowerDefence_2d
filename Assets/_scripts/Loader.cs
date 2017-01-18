using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {
	public GameObject game_manager;
	void Awake() {
		if (Game_manager.instance == null) 
			Instantiate (game_manager);
		
		/*KeyValuePair<int,string> course = new KeyValuePair<int, string>(1,"fuck society");
		course.printKeyValue ();

		KeyValuePair<string,string> lesson = new KeyValuePair<string, string>("society 101","death to society");
		lesson.printKeyValue ();*/


	}

}
	/*public class KeyValuePair<Tkey,Tvalue> {

		public Tkey key;
		public Tvalue value;

		public KeyValuePair(Tkey key,Tvalue value) {

			this.key = key;
			this.value = value;

		}

		public void printKeyValue(){

			Debug.Log ("key " + key.ToString());
			Debug.Log ("value " + value.ToString());
		
		}

}*/
