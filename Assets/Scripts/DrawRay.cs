using UnityEngine;
using System.Collections;

public class DrawRay : MonoBehaviour 
{
    public Vector3 RayPoint;

    readonly Color RAY_COLOR = new Color(1.0F, 1.0F, 0.0F, 0.1F);
	// Use this for initialization
	void Start () 
    {
        RayPoint = new Vector2(Random.Range(-8.0F, 6.0F), Random.Range(5.0F, -3.0F));
	}
	
	// Update is called once per frame
	void Update () 
    {
        lookTowardsRayPoint();
        DrawLine(transform.position, RayPoint, RAY_COLOR, 0.4F, 0.01F, Time.deltaTime);
	}

    void DrawLine(Vector3 start, Vector3 end, Color color, float widthBegin, float widthEnd, float duration = 0.2f)
    {
        GameObject myLine = new GameObject();
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        lr.SetColors(color, color);
        lr.SetWidth(widthBegin, widthEnd);
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
        lr.sortingLayerName = "Mirrors";
        GameObject.Destroy(myLine, duration);
    }

    private void lookTowardsRayPoint()
    {
        Vector3 diff = RayPoint - transform.position;
        diff.Normalize();
        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0F, 0.0F, rotZ - 90.0F);
    }
}
