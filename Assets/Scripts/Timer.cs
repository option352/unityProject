using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    float CountTimer = 0;

	// Use this for initialization
	void Start () {
        CountTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        CountTimer += Time.deltaTime;
        GetComponent<Text>().text = CountTimer.ToString("F2");
	}
}
