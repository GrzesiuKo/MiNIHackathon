using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform tree;
    public Rigidbody rb;
    public float speed = 0.05f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        tree = GameObject.FindGameObjectWithTag("choinka").transform;
        Debug.Log("Present::Move: tree.x tree.y tree.z" + tree.position.x + "   " + tree.position.y + "   " + tree.position.z);
        Vector3 v = new Vector3(tree.position.x - transform.position.x, tree.position.y - transform.position.y, tree.position.z - transform.position.z);

        transform.position = transform.position + speed * v.normalized;

        //rb.AddForce(v* speed);
	}

    public void setTree(Transform tree)
    {
        this.tree = tree;
    }
    
}
