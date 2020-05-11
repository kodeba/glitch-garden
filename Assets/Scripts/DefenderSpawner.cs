using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Spawn(GetSquareClick());
    }

    private Vector2 GetSquareClick()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        return Camera.main.ScreenToWorldPoint(clickPos);
    }

    private void Spawn(Vector2 worldPos)
    {
        Instantiate(defender, worldPos, Quaternion.identity);
    }


}
