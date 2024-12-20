using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    private Grid grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid(4, 2, 10f, new Vector3(20,0));
        new Grid(2, 5, 5f, new Vector3(0, -20));
        new Grid(10, 10, 20f, new Vector3(-100f, -20));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
