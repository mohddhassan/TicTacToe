using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeView : MonoBehaviour
{
    public GameObject cellPrefab;
    public int row;
    public int col;
    public float horizontalSpacing;
    public float verticalSpacing;
    private int counter = 0;
    TicTacToeGrid ticTacToeGrid;

    void Start()
    {
        
        InitializeGrid();
    }

    public void InitializeGrid()
    {
        ticTacToeGrid = new TicTacToeGrid(row, col);
        ticTacToeGrid.onCellCreated += OnCellCreated;        
        ticTacToeGrid.InitializeCells();
    }

    public void OnCellCreated(Cell cell)
    {

        GameObject temp;
        CellPositionSetUp();
        temp = Instantiate(cellPrefab, new Vector3(horizontalSpacing, 0, verticalSpacing), cellPrefab.transform.rotation);
        counter++;
        temp.GetComponent<CellView>().SetCell(cell);
    }


    void CellPositionSetUp()
    {
        if (counter == row)
        {
            verticalSpacing += 2.0f;
            counter = 0;
            horizontalSpacing = 4.0f;
        }
        else
        {
            horizontalSpacing += 2.0f;
        }
    }
}
