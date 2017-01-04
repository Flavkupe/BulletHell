using UnityEngine;
using System.Collections;

public class LevelObstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 p = this.transform.position;
		this.transform.position = new Vector3 (p.x, p.y - GameManager.Instance.LevelSpeed);
	}

	void Update () {
		if (this.transform.position.y < -10.0f) {
			Destroy (this.gameObject);
		}
	}
}
