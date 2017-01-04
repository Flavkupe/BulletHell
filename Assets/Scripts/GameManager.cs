using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float LevelSpeed = 1.0f;

	public Camera levelCamera;

	private static GameManager instance = null;

	public static GameManager Instance { get { return instance; } }

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
