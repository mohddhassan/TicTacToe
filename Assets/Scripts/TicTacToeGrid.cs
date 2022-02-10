using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeGrid : Matrix
{
    List<List<Cell>> cellGrid;
       
    public delegate void OnCellCreated(Cell cell);
    public event OnCellCreated onCellCreated;

    public TicTacToeGrid(int numOfRows, int numOfCols) : base(numOfRows, numOfCols)
    {
        cellGrid = new List<List<Cell>>();
    }

    public void InitializeCells()
    {
        Debug.Log("Initialize ran");
        for (int i = 0; i < numOfRows; i++)
        {
            cellGrid.Add(new List<Cell>());            
            for (int j = 0; j < numOfColumns; j++)
            {
                Cell tempCell = new Cell(i, j);
                cellGrid[i].Add(tempCell);
                onCellCreated?.Invoke(cellGrid[i][j]);
                             
                    

            }


        }
        

    }

   
}



