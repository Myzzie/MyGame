using UnityEngine;
using System.Collections;

public class SaveLoad : MonoBehaviour {
	
	
	
	
	void Start()
	{
		LoadInformation.LoadAllInformation();
		LoadInformation.LoadPlayerStats();
	}
	
	
	
	public void Save()
	{
		SaveInformation.SaveAllInformation();
		SaveInformation.SavePlayerStats();
		PlayerPrefs.Save ();
	}
	public void Load()
	{
		LoadInformation.LoadAllInformation();
		LoadInformation.LoadPlayerStats();
		
		
	}
	

	

	
	
	public void OnApplicationQuit()
	{
		SaveInformation.SaveAllInformation();
		SaveInformation.SavePlayerStats();
		PlayerPrefs.Save ();
	}
	
}
