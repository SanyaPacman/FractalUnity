using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{

    public int CountIteration=1;
    public int CurrIteration = 1;
    List<Vector2> Items;
    // static int Current= CountIteration;
    void Start()
    {
        BrakeLine();
    }
    
    void GetChilds()
    {
        Items = new List<Vector2>();
        for (int i = 0; i < transform.childCount; i++)
            Items.Add(transform.GetChild(i).transform.position);
    }
    void BrakeLine()
    {
        GetChilds();
        var iteration1 = MyMath.BrakeCurve(Items);
        var obj = new GameObject(string.Format("iteration{0}", CurrIteration));
        obj.transform.position = transform.position;
        var ParentGizmos = gameObject.GetComponent<GizmosBlade>();
        obj.AddComponent<GizmosBlade>();
        var ChildGizmos = obj.GetComponent<GizmosBlade>();
        ChildGizmos.LineColor = ParentGizmos.LineColor;
        ChildGizmos.PointColor = ParentGizmos.PointColor;
        ChildGizmos.rad = ParentGizmos.rad;

        for (int i = 0; i < iteration1.Count; i++)
        {
            var ChildObj = new GameObject(string.Format("P{0}", i));
            ChildObj.transform.position = iteration1[i];
            ChildObj.transform.parent = (obj.transform);
        }
        if (CountIteration>0)
        {
            obj.AddComponent<Line>().CountIteration = CountIteration - 1;
            obj.GetComponent<Line>().CurrIteration=obj.GetComponent<Line>().CurrIteration++;
        }
    }
}
