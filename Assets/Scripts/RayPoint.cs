using UnityEngine;
using System.Collections;

public class RayPoint : MonoBehaviour 
{
    public float Speed;
    public bool IsGoRight = false;
    public bool IsGoLeft = false;
    public bool IsGoUp = false;
    public bool IsGoDown = false;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (IsGoRight)
            this.transform.position = new Vector3(this.transform.position.x + Speed * Time.deltaTime, this.transform.position.y);
        if (IsGoLeft)
            this.transform.position = new Vector3(this.transform.position.x - Speed * Time.deltaTime, this.transform.position.y);
        if (IsGoUp)
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + Speed * Time.deltaTime);
        if (IsGoDown)
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - Speed * Time.deltaTime);

        if (this.transform.position.x < -8.0F)
            this.transform.position = new Vector3(-8.0F, this.transform.position.y);
        if (this.transform.position.x > 6.0F)
            this.transform.position = new Vector3(6.0F, this.transform.position.y);
        if (this.transform.position.y > 5.0F)
            this.transform.position = new Vector3(this.transform.position.x, 5.0F);
        if (this.transform.position.y < -2.0F)
            this.transform.position = new Vector3(this.transform.position.x, -2.0F);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision...");
        
        Ship shipScript = other.gameObject.GetComponent<Ship>();

        if (shipScript == null)
            return;
        
        Destroy(other.gameObject);
    }
}
