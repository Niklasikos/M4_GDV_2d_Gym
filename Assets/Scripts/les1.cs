using UnityEngine;
using UnityEngine.Tilemaps;

public class les1 : MonoBehaviour
{
    [SerializeField] Tilemap myTileMap;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Debug.Log($"{mousePos}");

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
            worldPosition.z = 0;
            Debug.Log(worldPosition);

            Vector3Int cellPosition = myTileMap.WorldToCell(worldPosition);

        }
    }
}