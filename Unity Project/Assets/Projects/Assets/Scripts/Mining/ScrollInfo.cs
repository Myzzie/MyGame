using UnityEngine;
using System.Collections;

public class ScrollInfo : MonoBehaviour {

	static ScrollInfo scrollInfo;
	public GameObject tooltip;
	public UnityEngine.UI.Text toolTip;

	void Awake()
	{
		

		tooltip.SetActive (false);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowInformation () {
		tooltip.SetActive(true);
		toolTip.text = "< Drag to switch Areas >";
	}
	public void HideInformation () {
		tooltip.SetActive(false);
	

	}


}
