using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour 
{
    public float Speed;
    public float Life;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - Speed * Time.deltaTime);
	}
}
