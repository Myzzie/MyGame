using UnityEngine;
using System.Collections;

public class PetStashManager : MonoBehaviour {



	//We make a static variable to our LoadingScreen instance
	static PetStashManager instance;
	//reference to gameobject with the static image 
	GameObject petStashManager;
	
	
	
	
	//function which executes on scene awake before the start function
	void Awake()
	{
		//find the ImageLS gameobject from the Hierarchy
		petStashManager = GameObject.Find("PetPurchase");
		//destroy the already existing instance, if any
		
		instance = this;    
		instance.petStashManager.SetActive(false);
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
		instance.petStashManager.SetActive(true);
	}
	//function to hide the loading screen
	public static void hide()
	{
		
		instance.petStashManager.SetActive(false);
	}

	
	
	
	
}