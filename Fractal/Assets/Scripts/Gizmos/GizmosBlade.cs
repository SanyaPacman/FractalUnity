using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosBlade : MonoBehaviour {
	public Color LineColor;
	public Color PointColor;
    public float rad;

	Transform[] items ;
	// Use this for initialization
	void Start () {
		items = new Transform[(transform.childCount)];
		for (int i = 0; i < transform.childCount; i++) 
		{
			//Debug.Log ("RERE " + i);
			items [i] = transform.GetChild (i).transform;
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
	void OnDrawGizmos()
	{
		Start ();
        Gizmos.color = PointColor;
        Gizmos.DrawSphere(items[0].position, rad);
        for (int i = 0; i < items.Length-1; i++) 
		{
			Gizmos.color =LineColor;
			Gizmos.DrawLine(items[i].position,items[i+1].position);
            Gizmos.color = PointColor;
            Gizmos.DrawSphere(items[i+1].position, rad);
        }
    }
}
