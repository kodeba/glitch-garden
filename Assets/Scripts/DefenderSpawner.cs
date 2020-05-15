using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {
        Spawn(GetSquareClick());
    }

    private Vector2 GetSquareClick()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        return SnapToGrid(worldPos);
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void Spawn(Vector2 roundedPos)
    {
        if(defender != null)
        {
            Instantiate(defender, roundedPos, Quaternion.identity);
        }
    }

    public void SetSelectedDefender(Defender defender)
    {
        this.defender = defender;
    }


}
