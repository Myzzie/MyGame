using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {


	public UnityEngine.UI.Text mineLevelDisplay;
	public UnityEngine.UI.Text battleLevelDisplay;
	public UnityEngine.UI.Text woodLevelDisplay;
	public UnityEngine.UI.Text fishLevelDisplay;
	public UnityEngine.UI.Text critLevelDisplay;
	public UnityEngine.UI.Text evasionLevelDisplay;
	public UnityEngine.UI.Text lifeLevelDisplay;

	// Update is called once per frame
	void Update () 
	{


		mineLevelDisplay.text = "" + Materials.materials.mineLevel;
		battleLevelDisplay.text = "" + Materials.materials.battleLevel;
		woodLevelDisplay.text = "" + Materials.materials.woodCuttingLevel;
		fishLevelDisplay.text = "" + Materials.materials.fishLevel;
		critLevelDisplay.text = "" + Materials.materials.critLevel;
		evasionLevelDisplay.text = "" + Materials.materials.evasionLevel;
		lifeLevelDisplay.text = "" + Materials.materials.lifeLevel;
	
	}
}
