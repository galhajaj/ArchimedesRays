using UnityEngine;
using System.Collections;

public class Mirror : MonoBehaviour 
{
    public int Index;

    private bool _isCurrent = false;
    private GameObject _ray;
	// Use this for initialization
	void Start () 
    {
        //_ray = gameObject.GetComponent<DrawRay>().RayPoint;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void SetCurrentMirror(int index)
    {
        _isCurrent = (index == Index);
    }

    public void GoRight()
    {
        if (!_isCurrent)
            return;

        if (_ray == null)
            _ray = gameObject.GetComponent<DrawRay>().RayPoint;

        _ray.GetComponent<RayPoint>().IsGoRight = true;
        _ray.GetComponent<RayPoint>().IsGoLeft = false;
    }

    public void GoLeft()
    {
        if (!_isCurrent)
            return;

        if (_ray == null)
            _ray = gameObject.GetComponent<DrawRay>().RayPoint;

        _ray.GetComponent<RayPoint>().IsGoLeft = true;
        _ray.GetComponent<RayPoint>().IsGoRight = false;
    }

    public void GoUp()
    {
        if (!_isCurrent)
            return;

        if (_ray == null)
            _ray = gameObject.GetComponent<DrawRay>().RayPoint;

        _ray.GetComponent<RayPoint>().IsGoUp = true;
        _ray.GetComponent<RayPoint>().IsGoDown = false;
    }

    public void GoDown()
    {
        if (!_isCurrent)
            return;

        if (_ray == null)
            _ray = gameObject.GetComponent<DrawRay>().RayPoint;

        _ray.GetComponent<RayPoint>().IsGoDown = true;
        _ray.GetComponent<RayPoint>().IsGoUp = false;
    }

    public void Stop()
    {
        if (!_isCurrent)
            return;

        if (_ray == null)
            _ray = gameObject.GetComponent<DrawRay>().RayPoint;

        _ray.GetComponent<RayPoint>().IsGoRight = false;
        _ray.GetComponent<RayPoint>().IsGoLeft = false;
        _ray.GetComponent<RayPoint>().IsGoUp = false;
        _ray.GetComponent<RayPoint>().IsGoDown = false;
    }
}
