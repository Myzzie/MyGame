using UnityEngine;
using System.Collections;

public class PetInfoManager : MonoBehaviour {

	//We make a static variable to our LoadingScreen instance
	static PetInfoManager instance;
	//reference to gameobject with the static image 
	GameObject petInfoManager;
	
	
	
	
	//function which executes on scene awake before the start function
	void Awake()
	{
		//find the ImageLS gameobject from the Hierarchy
		petInfoManager = GameObject.Find("PetInfo");
		//destroy the already existing instance, if any
		
		instance = this;    
		instance.petInfoManager.SetActive(false);
	}
	
	
	
	void Update()
	{
		
	}
	public static void show()
	{
		instance.petInfoManager.SetActive(true);
	}
	
	public static void hide()
	{
		instance.petInfoManager.SetActive(false);
	}
	

}
