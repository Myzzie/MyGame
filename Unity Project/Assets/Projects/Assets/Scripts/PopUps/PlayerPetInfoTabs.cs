using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerPetInfoTabs : MonoBehaviour {
	
	public GameObject buttonPlayer;
	public GameObject buttonPet;
	public bool openPetInfo;
	public bool openPlayerInfo;
	
	void Awake()
	{
		buttonPlayer.GetComponent<Button>().interactable = false;
	}
	
	void Start ()
	{
		openPlayerInfo = true;
		openPetInfo = false;
	}

	void Update()
	{
		if (openPlayerInfo)
		{
			buttonPlayer.GetComponent<Button>().interactable = false;
		}
		else buttonPlayer.GetComponent<Button>().interactable = true;
		if (openPetInfo)
		{
			buttonPet.GetComponent<Button>().interactable = false;
		}
		else buttonPet.GetComponent<Button>().interactable = true;
	}
	
	
	public void OpenPetInfo()
	{
		
		if (!openPetInfo) 
		{

			PetInfoManager.show ();
			openPetInfo = true;
			PlayerInfoManager.hide();
			openPlayerInfo = false;


		}
	
		
	} 
	public void OpenPlayerInfo()
	{
		
		if (!openPlayerInfo) 
		{
			
			PlayerInfoManager.show ();
			openPlayerInfo = true;
			PetInfoManager.hide();
			openPetInfo = false;
		}

		
	} 
}
