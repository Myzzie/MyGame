using UnityEngine;
using System.Collections;

public class ClassPurchaseManager : MonoBehaviour {

	//We make a static variable to our LoadingScreen instance
	static ClassPurchaseManager instance;
	//reference to gameobject with the static image 
	GameObject classPurchaseManager;
	
	
	
	
	//function which executes on scene awake before the start function
	void Awake()
	{
		//find the ImageLS gameobject from the Hierarchy
		classPurchaseManager = GameObject.Find("ClassPurchase");
		//destroy the already existing instance, if any
		
		instance = this;    
		instance.classPurchaseManager.SetActive(false);
		DontDestroyOnLoad(this);  //make this object persistent between scenes
	}
	
	
	
	void Update()
	{
		
	}
	//function to enable the loading screen
	public static void show()
	{
		
		//if instance does not exists return from this function
		
		//enable the loading image object 
		instance.classPurchaseManager.SetActive(true);
	}
	//function to hide the loading screen
	public static void hide()
	{
		
		instance.classPurchaseManager.SetActive(false);
	}

	
	
	
	
}