using UnityEngine;
using System.Collections;

public class PlayerInfoManager : MonoBehaviour {


	//We make a static variable to our LoadingScreen instance
	static PlayerInfoManager instance;
	//reference to gameobject with the static image 
	GameObject playerInfoManager;
	
	
	
	
	//function which executes on scene awake before the start function
	void Awake()
	{
		//find the ImageLS gameobject from the Hierarchy
		playerInfoManager = GameObject.Find("PlayerInfo");
		//destroy the already existing instance, if any
		
		instance = this;    
		instance.playerInfoManager.SetActive(true);
	}
	
	
	
	void Update()
	{
		
	}
	public static void show()
	{
		instance.playerInfoManager.SetActive(true);
	}
	
	public static void hide()
	{
		instance.playerInfoManager.SetActive(false);
	}

}
