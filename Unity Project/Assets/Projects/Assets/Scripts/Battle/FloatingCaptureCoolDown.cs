using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FloatingCaptureCoolDown : MonoBehaviour {
	
	public Text myGUItext;
	private float timer = 30f;
	
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;
		myGUItext.text = "CoolDown" + " / " + "(" + timer.ToString("f0")+ ")";
		
		if (timer <= 0)
		{
			Destroy(gameObject);
		}
	
	}
	


	
	
	
	
}
