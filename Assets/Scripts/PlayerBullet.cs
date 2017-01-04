using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

	public float speed = 0.1f;

	public float waveMagnitude = 0.05f;
	public float waveSpeed = 10f;

	public float phase = 0.0f;
	private float phase2 = 0.0f;

	public enum BulletPattern {
		WaveForward,
		CircleOut,
	}
		
	public BulletPattern bulletPattern = BulletPattern.WaveForward;

	// Use this for initialization
	void Start () {
	}

	private void MoveWaveForward() {
		Vector3 p = this.gameObject.transform.position;
		float x = p.x + Mathf.Sin(phase) * waveMagnitude;
		float y = p.y + speed;
		p = new Vector3 (x, y);
		this.gameObject.transform.position = p;
	}

	private void MoveCircleOut() {
		Vector3 p = this.gameObject.transform.localPosition;
		float x = Mathf.Sin(phase) * waveMagnitude;
		float y = Mathf.Cos(phase) * waveMagnitude;
		p = new Vector3 (x, y);
		this.gameObject.transform.localPosition = p;
	}

	// Update is called once per frame
	void FixedUpdate () {
		switch (bulletPattern) {
		case BulletPattern.WaveForward:
			this.MoveWaveForward ();
			break;
		case BulletPattern.CircleOut:
			this.MoveCircleOut ();
			break;
		}
	}

	void Update() {
		this.phase += Time.deltaTime * waveSpeed;

		if (this.gameObject.transform.position.y > 30.0f) {
			Destroy (this.gameObject);
		}	
	}
}
