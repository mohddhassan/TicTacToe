using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellView : MonoBehaviour
{
    public List<GameObject> displayObject;
    public Cell cell;


    void Start()
    {
        cell = new Cell();
        Debug.Log("View Start ran");
        InitializeCellView();

    }
    void Update()
    {


    }
    private void InitializeCellView()
    {
        cell.statusUpdated += SetStatus;

    }


    public void SetStatus(Cell.Status status)
    {
        for (int i = 0; i < displayObject.Count; i++)
        {
            if ((int)status == i)
            {
                displayObject[i].SetActive(true);
                Debug.Log("Hello  Je");
            }
            else
            {
                displayObject[i].SetActive(false);
            }
        }
    }

    private void OnMouseDown()
    {
        cell.statusUpdated += SetStatus;        
        cell.CellInteraction();
        Debug.Log("Mouse button pressed");


    }

    public void SetCell(Cell cell)
    {
        this.cell = cell;
        //SetStatus(this.cell.GetStatus());
    }

}



