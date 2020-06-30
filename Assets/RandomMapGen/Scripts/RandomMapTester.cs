﻿// this class is to test the random map generation process

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapTester : MonoBehaviour
{
    //variables exposed to the editor
    [Header("Map Dimensions")] //title
    public int mapWidth = 20;
    public int mapHeight = 20;


    [Space] [Header("Visualize Map")]
    public GameObject mapContainer;
    public GameObject tilePrefab;
    public Vector2 tileSize = new Vector2(16,16);
    
    
    

    public Map map;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        map = new Map();
    }


    public void MakeMap()
    {
        map.NewMap(mapWidth, mapHeight);
        Debug.Log("Created a new "+map.columns + "x" + map.rows+" map.");
        CreateGrid();
    }

    private void CreateGrid()
    {
        var total = map.tiles.Length;
        var maxColumns = map.columns;

        var column = 0;
        var row = 0;

        for (int i = 0; i < total; i++)
        {
            column = i % maxColumns;

            var newX = column * tileSize.x;
            var newY = -row * tileSize.y;

            var go = Instantiate(tilePrefab);
            go.name = "Tile " + i;
            go.transform.SetParent(mapContainer.transform);
            go.transform.position =  new Vector3(newX, newY, 0);

            if (column == (maxColumns - 1))
            {
                row++;
            }
            
        }
        
    }
    
}
