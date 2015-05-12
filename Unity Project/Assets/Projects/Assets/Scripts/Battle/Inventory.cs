using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	static Inventory inventory;
	public GameObject instance;






	void Awake ()
	{
		inventory = this;
		inventory.instance.SetActive (false);
	}

	public void OpenInventory()
	{
		inventory.instance.SetActive (true);
	}

}
