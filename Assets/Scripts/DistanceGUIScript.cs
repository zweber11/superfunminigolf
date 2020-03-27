using UnityEngine;
using System.Collections;

public class DistanceGUIScript : MonoBehaviour {

	void Start ()
	{
		GameControl.control.totalDistance = 0;
	}

	void Update () 
	{
		GetComponent<GUIText>().text = "Disance: " + (Mathf.Round (GameControl.control.totalDistance)) + " in.";
	}
}
