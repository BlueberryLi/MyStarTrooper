using UnityEngine;
using System.Collections;

public class MissileStarter : MonoBehaviour {
    public GameObject missile;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            Vector3 position = new Vector3(0, -2, 10);
            position = transform.TransformPoint(position);
            GameObject thisMissile = Instantiate(missile, position, transform.rotation) as GameObject;
            Physics.IgnoreCollision(thisMissile.GetComponent<Collider>(), GetComponent<Collider>());
        }
	}
}
