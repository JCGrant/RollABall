using UnityEngine;

public class Rotator : MonoBehaviour {
	
    private Vector3 rotationVelocity = new Vector3(15, 30, 45);

	void Update () {
        transform.Rotate(rotationVelocity * Time.deltaTime);
	}

}
