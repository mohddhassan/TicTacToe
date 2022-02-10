using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    public int row;
    public int col;
    public enum Status { none, cross, circle, win, loose };
    Status status;
    public delegate void StatusUpdated(Status status);
    public event StatusUpdated statusUpdated;

    public delegate void OnCellInteraction(int row, int col);
    public event OnCellInteraction onCellInteraction;  

    public Cell()
    {
        status = Status.none;
        row = 0;
        col = 0;
    }

    public Cell(int row, int col)
    {
        this.row = row;
        this.col = col;
        status = Status.none;
    }

    public Cell(int row, int col, Status status)
    {
        this.row = row;
        this.col = col;
        this.status = status;
    }

    public void CellInteraction()
    {
        //SetStatus(Status.cross);
        onCellInteraction?.Invoke(GetRow(), GetCol());

    }

    public void SetStatus(Status status)
    {
        this.status = status;
        statusUpdated?.Invoke(status);
    }
    public Status GetStatus()
    {
        return status;
    }

    public void SetRowAndCol(int r, int c)
    {
        this.row = r;
        this.col = c;
    }


    public void SetRow(int row)
    {
        this.row = row;
    }

    public int GetRow()
    {
        return row;
    }

    public void SetCol(int col)
    {
        this.col = col;
    }

    public int GetCol()
    {
        return col;

    } 


}

