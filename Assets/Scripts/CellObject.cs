using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellObject : MonoBehaviour
{
    public bool m_IsAlive = false;
    public int m_NumNeighbours = 0;

    public void OnMouseDown()
    {
        SetStatus(!m_IsAlive);
        Debug.Log("Hit here");
    }

    public void SetStatus(bool alive)
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        m_IsAlive = alive;

        renderer.color = (alive == true) ? Color.black : Color.white;

    }
}
