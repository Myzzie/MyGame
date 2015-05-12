using UnityEngine;
using System.Collections;

public class StatsManager : MonoBehaviour
{
	//We make a static variable to our LoadingScreen instance
	static StatsManager instance;
	//reference to gameobject with the static image 
	GameObject statsManager;



	
	//function which executes on scene awake before the start function
	void Awake()
	{
		//find the ImageLS gameobject from the Hierarchy
		statsManager = GameObject.Find("Canvas3");
		//destroy the already existing instance, if any

		instance = this;    
		instance.statsManager.SetActive(false);
	}


	
	void Update()
	{

	}
	public static void show()
	{
		instance.statsManager.SetActive(true);
	}

	public static void hide()
	{
		instance.statsManager.SetActive(false);
	}



	
	
}