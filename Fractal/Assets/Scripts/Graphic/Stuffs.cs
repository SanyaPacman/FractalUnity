using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuffs : MonoBehaviour {
    /*
public class ParamLine  
{
    public float X1;
    public float Y1;

    public float X12;
    public float Y12;

    public float X2;
    public float Y2;

    public ParamLine(Vector2 p1, Vector2 p2)
    {
        //var p2 = p1 + direction * 100;
        X1 = p1.x;
        Y1 = p1.y;

        X2 = p2.x;
        Y2 = p2.y;

        X12 = X2 - X1;
        Y12 = Y2 - Y1;
    }
    public ParamLine(Vector2 p1, float x12,float y12)
    {
        X1 = p1.x;
        Y1 = p1.y;

        X2 = p1.x+ x12;
        Y2 = p1.y + y12;

        X12 = x12;
        Y12 = y12;
    }


    public Vector2 GiveVector(float lambda)
    {
        return new Vector2(X1 + lambda * X12, Y1 + lambda * Y12);
    }
} 
public static class MyMath
{
    public static Vector2 GetCrossingVert(ParamLine l1, ParamLine l2)
    {
        float a = (l1.Y1 - l2.Y1) / l2.Y12 + (l1.Y12 * (l2.X1 - l1.X1) / (l2.Y12 * l1.X12));
        float lam = a * l1.X12 * l2.Y12 / (l1.X12 * l2.Y12 - l2.X12 * l1.Y12);
        return l2.GiveVector(lam);
    }
    public static List<Vector2> BrakeCurve(List<Vector2> Points)
    {
        var Answer = new List<Vector2>();
        for (int i = 0; i < Points.Count - 1; i++)
        {
            Answer.AddRange(BrakeLine(Points[i], Points[i + 1]));
        }
        return new List<Vector2>();
    }
    public static List<Vector2> BrakeLine(Vector2 InputP1, Vector2 InputP2, bool AddFirstPoint = true)
    {
        var Answer = new List<Vector2>();
        if (AddFirstPoint)
            Answer.Add(InputP1);
        var P2 = InputP1 + (InputP2 - InputP1) / 3;
        var P4 = InputP1 + (InputP2 - InputP1) / 3 * 2;
        Answer.Add(P2);
        var LineP2P4 = new ParamLine(P2, P4);
        var LineP2P3 = new ParamLine(InputP1 + (InputP2 - InputP1) / 2, LineP2P4.Y12, -LineP2P4.X12);
        var P3 = LineP2P3.GiveVector(Mathf.Cos(Mathf.PI / 3) * Vector2.Distance(P2, P4) / 2);// new Vector2(LineP2P3.X2, LineP2P3.Y2);
        
        Debug.Log(string.Format("<Color=red> {0} </Color>", Vector2.Distance(P2, P4)));
        Debug.Log(string.Format("<Color=red> {0} </Color>", Vector2.Distance(P2, P3)));
        Debug.Log(string.Format("<Color=red> {0} </Color>", Vector2.Distance(P4, P2)));
        Debug.Log(InputP1);
        Debug.Log(P2);
        Debug.Log(P3);
        Debug.Log(P4);
        Debug.Log(InputP2);        
        Answer.Add(P3);
        Answer.Add(P4);
        Answer.Add(InputP2);
        return Answer;
    }
}
    */
}
