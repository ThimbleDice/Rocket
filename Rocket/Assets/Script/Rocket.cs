using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public Rigidbody rocketRigidBody;
    [SerializeField] public float boostPower = 100;
    [SerializeField] public float trust = 2;
    [SerializeField] public float forceDeRelation = 10;

    // Use this for initialization
    void Start () {
        rocketRigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        RocketBoost();
        RocketRotation();
    }

    private void RocketBoost()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            rocketRigidBody.AddForce(new Vector3(0, boostPower, 0));
        }
    }

    private void RocketRotation()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(forceDeRelation, 0, 0), new Vector3(0, trust, 0));
        }
        else if(Input.GetAxis("Horizontal") > 0)
        {
            rocketRigidBody.AddForceAtPosition(new Vector3(-forceDeRelation, 0, 0), new Vector3(0, trust, 0));
        }
    }
}
