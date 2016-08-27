using UnityEngine;
using System.Collections;

public class ShipsGenerator : MonoBehaviour 
{
    public GameObject ShipObject;
    public float TimeToGenerateShip;

    private float _lastTimeShipGenerated = 0.0F;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        _lastTimeShipGenerated -= Time.deltaTime;

        if (_lastTimeShipGenerated <= 0.0F)
        {
            GameObject ship = Instantiate(ShipObject, new Vector3(Random.Range(-8.0F, 6.0F), 6.0F), Quaternion.identity) as GameObject;

            _lastTimeShipGenerated = TimeToGenerateShip;
        }
	}
}
