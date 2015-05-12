using UnityEngine;
using System.Collections;

public class UnlockFishing : MonoBehaviour {


	static UnlockFishing unlockFishing;
	public GameObject instance;



	void Awake ()
	{
		unlockFishing = this;
		unlockFishing.instance.SetActive (true);
	}

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		public static void ShowFishing()
		{
			unlockFishing.instance.SetActive(false);
		}

}
