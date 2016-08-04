using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    public Vector3 offset;

	void Start () {
        offset = transform.position - player.transform.position;
	}
	
    // LateUpdate guaranteed to run after all other updates
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
