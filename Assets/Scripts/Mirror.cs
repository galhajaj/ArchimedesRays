using UnityEngine;
using System.Collections;

public class Mirror : MonoBehaviour 
{
    public int Index;

    private bool _isCurrent = false;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void SetCurrentMirror(int index)
    {
        _isCurrent = (index == Index);
    }
}
