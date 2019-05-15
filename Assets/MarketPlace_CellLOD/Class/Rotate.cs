using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	void Update () {
        this.gameObject.transform.Rotate(0, 2 * Time.deltaTime, 0);
    }
}
