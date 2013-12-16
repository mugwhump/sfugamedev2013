using UnityEngine;
using System.Collections;

//Put this on an object with a trigger collider to Teleport to a level
public class LevelTeleporter : MonoBehaviour {
	public string level;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) {
		Application.LoadLevel(level);
	}
}
