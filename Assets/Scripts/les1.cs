using UnityEngine;
using UnityEngine.Tilemaps;

public class les1 : MonoBehaviour
{
    [SerializeField] Tilemap myTileMap;
    BoundsInt bounds;
    int width, height;
    int x0, y0;
    // public int rand;
    // public Color color;
    void Start()
    {
        bounds = myTileMap.cellBounds;
        width = bounds.size.x;
        height = bounds.size.y;
        x0 = bounds.xMin;
        y0 = bounds.yMin;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Debug.Log($"{mousePos}");
            // System.Random rnd = new System.Random();
            // int rand = rnd.Next(1, 5);
            // switch(rand)
            // { 
            //     case 1:
            //         color = Color.black;
            //     break;

            //     case 2:
            //         color = Color.blue;
            //     break;

            //     case 3:
            //         color = Color.red;
            //     break;

            //     case 4:
            //         color = Color.yellow;
            //     break;

            //     case 5:
            //         color = Color.green;
            //     break;
            // }

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            worldPosition.z = 0;
            Debug.Log(worldPosition);

            Vector3Int cellPosition = myTileMap.WorldToCell(worldPosition);

            for (int i = bounds.xMin; i < bounds.xMax; i++)
            {
                for (int j = bounds.yMin; j < bounds.yMax; j++)
                {
                    Vector3Int pos = new Vector3Int(i, j, 0);
                    if (myTileMap.HasTile(pos) == true)
                    {
                        myTileMap.SetTileFlags(pos, TileFlags.None);
                        myTileMap.SetColor(pos, Color.white);
                    }
                    if (myTileMap.HasTile(cellPosition) == true)
                    {
                        myTileMap.SetTileFlags(cellPosition, TileFlags.None);
                        myTileMap.SetColor(cellPosition, Color.red);
                    }
                }
            }


        }
    }
}