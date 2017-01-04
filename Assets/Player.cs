using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public PlayerBullet playerBullet;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {

		float speed = 0.05f;
		Vector3 t = this.gameObject.transform.position; 
		if (Input.GetKey(KeyCode.UpArrow)) {			
			t = new Vector3 (t.x, t.y + speed);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {			
			t = new Vector3 (t.x, t.y - speed);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {			
			t = new Vector3 (t.x + speed, t.y);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {			
			t = new Vector3 (t.x - speed, t.y);
		}

		this.gameObject.transform.position = t;
	}

	public int bulletCount = 1;

	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			float phase = 0.0f;
			for (float i = 0.0f; i < (float)bulletCount; i++) {				
				if (playerBullet != null) {
					PlayerBullet bullet = Instantiate(playerBullet);
					bullet.phase = phase;

					if (bullet.bulletPattern == PlayerBullet.BulletPattern.CircleOut) {
						bullet.transform.parent = this.transform;
					} else {
						bullet.transform.position = this.transform.position;
					}
				}

				phase += ((2.0f * Mathf.PI) / bulletCount);
			}
		}
	}
}
