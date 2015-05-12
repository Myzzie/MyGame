using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeWoodBackground : MonoBehaviour {
	
	private bool changedFirstBackground;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!changedFirstBackground){
		if (Materials.materials.woodCuttingLevel >= 10)
		{
				changedFirstBackground = true;
			ChangeWoodBackground.ChangeToSecondImage();
		}
		}
	}
	
	
	public static void ChangeToSecondImage()
	{
		Destroy (GameObject.Find ("FirstBackground"));
		GameObject Background = Instantiate (Resources.Load ("Prefabs/SecondBackground")) as GameObject;
		Background.transform.SetParent ((GameObject.Find ("Background").transform), false);
	}
}
