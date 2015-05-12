using UnityEngine;
using System.Collections;

public class SpawnFadeInMenu : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		GameObject FadeInMenu = Instantiate (Resources.Load ("Prefabs/FadeInMenu")) as GameObject;
		FadeInMenu.transform.SetParent ((GameObject.Find ("Menu").transform), false);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
