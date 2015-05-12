using UnityEngine;
using System.Collections;

public class MarketManager : MonoBehaviour
{
	//We make a static variable to our LoadingScreen instance
	static MarketManager instance;
	//reference to gameobject with the static image 
	GameObject marketManager;
	
	
	
	
	//function which executes on scene awake before the start function
	void Awake()
	{
		//find the ImageLS gameobject from the Hierarchy
		marketManager = GameObject.Find("CanvasMarket");
		//destroy the already existing instance, if any
		
		instance = this;    
		instance.marketManager.SetActive(false);
	}
	
	
	
	void Update()
	{
		
	}
	public static void show()
	{
		instance.marketManager.SetActive(true);
	}
	
	public static void hide()
	{
		instance.marketManager.SetActive(false);
	}
	
	
	
	
	
}