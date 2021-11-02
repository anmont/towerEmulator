

using UnityEngine;

public class smoothCamera : MonoBehaviour {

	public Transform target;
    public Camera myCamera;

	public float smoothSpeed = 0.125f;
	public Vector3 offset = new Vector3(0.0f, 1f, -10.0f);

	void FixedUpdate ()
	{
        myCamera.transform.LookAt(target);
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(myCamera.transform.position, desiredPosition, smoothSpeed);
		myCamera.transform.position = smoothedPosition;
	}

}