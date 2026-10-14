using UnityEngine;
using System.Collections.Generic;

public class Breakable : MonoBehaviour
{

    public List<GameObject> breakablePieces;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    public void Break()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(true);
            item.transform.parent = null;
        }
        gameObject.SetActive(false);
    }
} 
