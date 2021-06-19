using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeSelectUtility : MonoBehaviour {
    public GameObject Exit;
    void OnEnable() {
        Exit.SetActive(false);
    }

    void OnDisable() {
        Exit.SetActive(true);
    }
}
