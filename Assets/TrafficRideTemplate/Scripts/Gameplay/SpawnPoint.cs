//
//  Orginally written by ALIyerEdon - Winter 2017 - Unity 5.4.1 64 bit
//

// Spawn car based on selected id in car selection scene

using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour {

	// List of the cars prefab
	public GameObject[] cars;
	public   MobileColorGrading colorProfile;

	void Awake () 
	{

		// We stored selected car id in PlayerPrefs.SetInt ("CarID") in garage scene    
		Instantiate (cars [PlayerPrefs.GetInt ("CurrentBike")], transform.position, transform.rotation);

		if (colorProfile) {
			MobileColorGrading current = GameObject.FindObjectOfType<MobileColorGrading> ();
			current.B = colorProfile.B;
			current.Contrast = colorProfile.Contrast;
			current.Exposure = colorProfile.Exposure;
			current.R = colorProfile.R;
			current.G = colorProfile.G;
			current.Gamma = colorProfile.Gamma;
			current.Saturation = colorProfile.Saturation;
		}

	}
}
