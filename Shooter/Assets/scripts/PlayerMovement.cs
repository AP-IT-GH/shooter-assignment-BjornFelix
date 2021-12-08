using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

	public float xSpeed = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
		float xOffset = horizontal * Time.deltaTime * xSpeed;
		float xNewPos = xOffset + transform.localPosition.x;
		transform.localPosition = new Vector3(xNewPos, transform.localPosition.y, transform.localPosition.z);
	}
}
