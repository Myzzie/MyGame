using UnityEngine;
using System.Collections;

public class PetStashPopUp : MonoBehaviour {


	public static bool Open;
	
	
	
	void Start ()
	{
		Open = false;
	}
	
	
	
	public void OpenPetUpgrade()
	{
		
		if (!Open) 
		{
			PetStashManager.show ();
			Open = true;
			ClassPurchaseManager.hide ();
			MarketManager.hide ();
			StatsManager.hide ();
			EquipmentPopUp.Open = false;
			MarketPopUp.Open = false;
			StatsPopUp.Open = false;
		}
		else if (Open) 
		{
			
			PetStashManager.hide ();
			Open = false;
		}
		
	} 
}
