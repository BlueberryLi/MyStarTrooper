using UnityEngine;
using System.Collections;

public class CameraTrack : MonoBehaviour {
    public Transform target;
    public float distance = 10.0f;
    public float height = 5.0f;
    private float heightDamping = 2.0f;
    private float rotationDamping = 3.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void LateUpdate()
    {
        if (!target)
            return;
        float targetRotation = target.eulerAngles.y;
        float targetHeight = target.position.y + height;
        float curRotation = transform.eulerAngles.y;
        float curHeight = transform.position.y;
        curRotation = Mathf.LerpAngle(curRotation, targetRotation, rotationDamping * Time.deltaTime);
        curHeight = Mathf.Lerp(curHeight, targetHeight, heightDamping * Time.deltaTime);
        Quaternion r = Quaternion.Euler(0.0f, curRotation, 0.0f);
        Vector3 p = target.position - r * Vector3.forward * distance;
        p.y = curHeight;
        transform.position = p;
        transform.LookAt(target);
    }
}
