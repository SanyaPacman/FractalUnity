using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParamLine  
{
    public Vector2 P1;

    public Vector2 Different;

    public Vector2 P2;

    public ParamLine(Vector2 p1, Vector2 p2, bool p2_dir=false)
    {
        //var p2 = p1 + direction * 100;
        if (!p2_dir)
        {
            P1 = p1;
            P2 = p2;
            Different = p2 - p1;
        }
        else
        {
            P1 = p1;
            P2 = p1 + p2;
            Different= p2;
        }
    }

    public Vector2 GiveVector(float lambda)
    {
        return new Vector2(P1.x + lambda * Different.x, P1.y + lambda * Different.y);
    }
} 
public static class MyMath
{
    public static List<Vector2> BrakeCurve(List<Vector2> Points)
    {
        var Answer = new List<Vector2>();
        for (int i = 0; i < Points.Count - 1; i++)
        {
            Answer.AddRange(BrakeLine(Points[i], Points[i + 1]));
        }
        return Answer;
    }
    public static List<Vector2> BrakeLine(Vector2 InputP1, Vector2 InputP2, bool AddFirstPoint = true)
    {
        var Answer = new List<Vector2>();

        var P2 = InputP1 + (InputP2 - InputP1) / 3;
        var P4 = InputP1 + (InputP2 - InputP1) / 3 * 2;
       
        var LineP2P4 = new ParamLine(P2, P4);        
        LineP2P4.Different.Normalize();
        var LineP2P3 = new ParamLine(InputP1 + (InputP2 - InputP1) / 2, new Vector2( LineP2P4.Different.y, -LineP2P4.Different.x),p2_dir:true);
        var P3 = InputP1 + (InputP2 - InputP1) / 2+ LineP2P3.Different.normalized* Mathf.Sin(Mathf.PI / 3) * Vector2.Distance(P2, P4) ;


        Debug.Log(string.Format("<Color=red> {0} </Color>", Vector2.Distance(P2, P4)));
        Debug.Log(string.Format("<Color=red> {0} </Color>", Vector2.Distance(P2, P3)));
        Debug.Log(string.Format("<Color=red> {0} </Color>", Vector2.Distance(P4, P3)));

        Debug.Log(string.Format("<Color=green> {0} </Color>", Vector2.Distance(InputP1, P2)));
        Debug.Log(string.Format("<Color=green> {0} </Color>", Vector2.Distance(P2, P4)));
        Debug.Log(string.Format("<Color=green> {0} </Color>", Vector2.Distance(P4, InputP2)));
        Debug.Log(InputP1);
        
        Debug.Log(P2);
        Debug.Log(P3);
        Debug.Log(P4);
        Debug.Log(InputP2);
        if (AddFirstPoint)
            Answer.Add(InputP1);
        Answer.Add(P2);
        Answer.Add(P3);
        Answer.Add(P4);
        Answer.Add(InputP2);
        return Answer;
    }
}


