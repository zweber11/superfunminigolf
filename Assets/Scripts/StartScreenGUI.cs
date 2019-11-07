using UnityEngine;
using System.Collections;

public class StartScreenGUI : MonoBehaviour {

	public 

	void OnGUI ()
	{
		GameControl.control.isHoleOver = false;
		GameControl.control.totalDistance = 0f;
		GameControl.control.strokes = 0;
		if(GUI.Button (new Rect (145, 185, 60, 25), "Hole 1"))
		{
			Application.LoadLevel("Hole1");
		}
		if(GUI.Button (new Rect (145, 220, 60, 25), "Hole 2"))
		{
			Application.LoadLevel("Hole2");
		}
		if(GUI.Button (new Rect (145, 255, 60, 25), "Hole 3"))
		{
			Application.LoadLevel("Hole3");
		}
		if(GUI.Button (new Rect (145, 290, 60, 25), "Hole 4"))
		{
			Application.LoadLevel("Hole4");
		}
		if(GUI.Button (new Rect (145, 325, 60, 25), "Hole 5"))
		{
			Application.LoadLevel("Hole5");
		}
		if(GUI.Button (new Rect (145, 360, 60, 25), "Hole 6"))
		{
			Application.LoadLevel("Hole6");
		}
		if(GUI.Button (new Rect (145, 395, 60, 25), "Hole 7"))
		{
			Application.LoadLevel("Hole7");
		}
		if(GUI.Button (new Rect (145, 430, 60, 25), "Hole 8"))
		{
			Application.LoadLevel("Hole8");
		}
		if(GUI.Button (new Rect (145, 465, 60, 25), "Hole 9"))
		{
			Application.LoadLevel("Hole9");
		}

		for (int i = 1; i < GameControl.control.totalNumberOfHoles; i++) 
		{
			GUI.Label (new Rect (265, 150+(35*i), 60, 25), "" + GameControl.control.lastStrokes[i]);
			GUI.Label (new Rect (325, 150+(35*i), 60, 40), "" + (Mathf.Round (GameControl.control.lastDistance[i]))+" in.");
			GUI.Label (new Rect (550, 150+(35*i), 60, 25), "" + GameControl.control.bestStrokes[i]);
			GUI.Label (new Rect (635, 150+(35*i), 60, 25), "" + (Mathf.Round (GameControl.control.highestDistance[i]))+" in.");
			GUI.Label (new Rect (755, 150+(35*i), 60, 25), "" + (Mathf.Round (GameControl.control.lowestDistance[i]))+" in.");

		}

		//if all hole complete show totals
		GUI.Label (new Rect (450, 510, 60, 25), "Totals");
		GUI.Label (new Rect (550, 510, 60, 25), "" + (GameControl.control.bestStrokes[0]));
		GUI.Label (new Rect (635, 510, 60, 25), "" + (Mathf.Round (GameControl.control.highestDistance[0]))+" in.");
		GUI.Label (new Rect (755, 510, 60, 25), "" + (Mathf.Round (GameControl.control.lowestDistance[0]))+" in.");



	}
}
