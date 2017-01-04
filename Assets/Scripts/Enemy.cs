using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public BoxCollider2D boundCollider;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 p = this.transform.position;
		if (boundCollider.IsTouchingLayers(LayerMask.NameToLayer("Camera"))) {
			this.transform.position = new Vector3 (p.x - 0.05f, p.y);
		}
		else {
			this.transform.position = new Vector3 (p.x, p.y - GameManager.Instance.LevelSpeed);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
