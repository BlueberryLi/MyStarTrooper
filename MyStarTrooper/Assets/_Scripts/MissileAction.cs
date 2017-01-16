using UnityEngine;
using System.Collections;

public class MissileAction : MonoBehaviour
{
    public GameObject explosion;
    private  Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        rb.AddForce(transform.TransformDirection(Vector3.forward*200));
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        GameObject exp = Instantiate(explosion, contact.point + contact.normal + contact.normal + contact.normal + contact.normal + contact.normal, Quaternion.identity) as GameObject;
        if(collision.gameObject.tag=="enemy")
        {
            Destroy(collision.gameObject);
        }
        Destroy(exp, 2.0f);
        Destroy(gameObject);
    }
}
