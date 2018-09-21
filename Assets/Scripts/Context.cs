using System;
using System.Linq;
using UnityEngine;

public class Context {

    private Vector3[] points;

    private int currentIdx;

    private int currentDirectIdx = 0;

    private int[] currentDirectAddendArray = new int[]{-5, 1, 5, -1};



    public void Init(Vector3[] points, int firstIdx){
        this.points = points;
        this.currentIdx = firstIdx;

    }


    public Vector3 GetNextPoint(){
        int nextIdx = this.currentIdx + this.currentDirectAddendArray[this.currentDirectIdx];
        if(nextIdx < 0 || points.Length-1 < nextIdx){
            nextIdx = this.currentIdx;
        }
        if(this.points[nextIdx].y > 0){
            nextIdx = this.currentIdx;
        }
        this.currentIdx = nextIdx;
        Debug.Log(this.currentIdx);
        return this.points[currentIdx];
                   
    }


    /// <summary>
    /// Gets the turn point.
    /// </summary>
    /// <returns>The turn point.</returns>
    /// <param name="direct">-1が反時計,1が時計まわり</param>
    public void SetTurnPoint(int direct){
        this.currentDirectIdx = (this.currentDirectAddendArray.Length + this.currentDirectIdx + direct) % this.currentDirectAddendArray.Length ;
    }

}
