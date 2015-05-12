using UnityEngine;
using System.Collections;

public class WoodPurchase : MonoBehaviour {
	


	public UnityEngine.UI.Text woodDisplay;
	public UnityEngine.UI.Text expDisplay;
	public CutWood cutWood;




	void Start()
	{
		if (WoodPerSec.lumberJack1)
		{
			StartCoroutine(WoodPerSec.FirstLumberJack());
		}
		if (WoodPerSec.lumberJack2)
		{
			StartCoroutine(WoodPerSec.SecondLumberJack());
		}
		if (WoodPerSec.lumberJack3)
		{
			StartCoroutine(WoodPerSec.ThirdLumberJack());
		}
		if (WoodPerSec.lumberJack4)
		{
			StartCoroutine(WoodPerSec.FourthLumberJack());
		}
		if (WoodPerSec.lumberJack5)
		{
			StartCoroutine(WoodPerSec.FifthLumberJack());
		}
		if (WoodPerSec.lumberJack6)
		{
			StartCoroutine(WoodPerSec.SixthLumberJack());
		}
		if (WoodPerSec.lumberJack7)
		{
			StartCoroutine(WoodPerSec.SeventhLumberJack());
		}
	}
	void Update () {
		woodDisplay.text = "" + Materials.materials.wood;

	
	}
	
	

	
}
