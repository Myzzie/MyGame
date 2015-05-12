using UnityEngine;
using System.Collections;

public class OnLoad : MonoBehaviour {


	public static OnLoad onLoad;
	

	void Awake (){
		if (onLoad == null) 
		{
			onLoad = this;
			DontDestroyOnLoad(transform.gameObject);

		} 
		else if(onLoad != this) 
		{
			Destroy(gameObject);
		}
	}
	
}