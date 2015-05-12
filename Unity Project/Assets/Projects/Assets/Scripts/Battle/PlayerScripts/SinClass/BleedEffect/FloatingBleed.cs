using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingBleed : MonoBehaviour {


		
		public Text myGUItext;
		private float guiTime = 12f;
		private float timer = 12f;
		
		

		
		void Update ()
		{
			
		timer -= Time.deltaTime;
		
		myGUItext.text = "Bleed Effect" + " / " + "(" + timer.ToString("f0")+ ")";
	
	
		}
		
		
		
		public void DisplayDamage()
		{
			
			// destory after time is up
			StartCoroutine(GuiDisplayTimer());
		}
		
		IEnumerator GuiDisplayTimer()
		{
			Bleed.startCoroutine = true;
			// Waits an amount of time
			yield return new WaitForSeconds(guiTime);
			Bleed.startCoroutine = false;
			// destory game object

			Destroy(gameObject);
			
		}
		
		
		
		
	}
