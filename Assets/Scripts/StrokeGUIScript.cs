using UnityEngine;
using System.Collections;

public class StrokeGUIScript : MonoBehaviour {

	void Start ()
	{
		GameControl.control.strokes = 0;
	}

	void Update () 
	{
		guiText.text = "Stokes: " + GameControl.control.strokes;
	}
}
