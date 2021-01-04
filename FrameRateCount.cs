using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FrameRateCount : MonoBehaviour {
		
	public Text _text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		_text.text = (1 / Time.smoothDeltaTime).ToString();
	}
}
