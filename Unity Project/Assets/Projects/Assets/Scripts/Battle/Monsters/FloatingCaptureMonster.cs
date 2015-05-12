using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FloatingCaptureMonster : MonoBehaviour {

	public Text myGUItext;
	private float guiTime = 1f;
	
	
	
	
	
	
	
	void Start ()
	{
		animation.Play ("MonsterGoldDropAnim");
	}
	
	void Update ()
	{
		
		transform.Translate(0, 1, Time.deltaTime);
		transform.Translate(0, Time.deltaTime, 1, Space.World);
		
		Color myColor = myGUItext.color;
		myColor.a -= Time.deltaTime / guiTime;
		myGUItext.color = myColor;
		
	}
	
	
	
	public void DisplayDamage(string damageMessage)
	{
		
		myGUItext.text = damageMessage;
		
		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
	}
	
	IEnumerator GuiDisplayTimer()
	{
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		
		// destory game object
		Destroy(gameObject);
	}
	

}
