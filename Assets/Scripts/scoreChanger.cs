using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreChanger : MonoBehaviour {

	[SerializeField]
	public Text scoreText;
	public string tex;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeScore(int delta) {
		if (scoreText) {
			int current = int.Parse (scoreText.text);
			scoreText.text = (current + delta).ToString();
		}
	}
}
