using UnityEngine;
using System.Collections;

public class Information : MonoBehaviour {

	static Information information;
	public ScrollInfo scrollInfo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Materials.materials.mineExp >= 10) {
			scrollInfo.ShowInformation ();
	}
		if (Materials.materials.battleLevel >= 2) {
			scrollInfo.HideInformation ();
		}
}
}

