using UnityEngine;
using System.Collections;

public class MarketPopUp : MonoBehaviour {
	
	
	public static bool Open;
	
	
	
	void Start ()
	{
		Open = false;
	}
	
	
	
	
	public void OpenMarket()
	{

		if (!Open) 
		{
			MarketManager.show ();
			Open = true;
			ClassPurchaseManager.hide ();
			PetStashManager.hide ();
			StatsManager.hide ();
		
			
			EquipmentPopUp.Open = false;
			PetStashPopUp.Open = false;
			StatsPopUp.Open = false;

			
		}
		else if (Open) 
		{
		
			MarketManager.hide ();
			Open = false;
			
			
		}
		
	} 
	

	
	
	
	
}
