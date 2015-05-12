using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingLifeSteal : MonoBehaviour {


		
		public Text myGUItext;
		private float guiTime = 1f;
		

		
		void Update ()
		{
			

			
			
			Color myColor = myGUItext.color;
		myColor.a -= Time.deltaTime / guiTime;
			myGUItext.color = myColor;
		}
		
		
		
		public void DisplayDamage(string damageMessage)
		{
		if (SinLifeSteal.stealChance) 
		{
			myGUItext.text = "Life Steal " + damageMessage;
			Debug.Log ("Read This");
			} 
			
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
