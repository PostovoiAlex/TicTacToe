using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] GameObject _tilePrefab;
    [SerializeField] int _dimentions;

    [ContextMenu("Awake")]
    private void Awake()
    {
        for (int i = 0; i < _dimentions; i++)
        {
            for (int j =0; j < _dimentions; j++)
            {
                GameObject copy = Instantiate(_tilePrefab);
                copy.transform.SetParent(transform);
                //copy.transform.localScale = Vector3.one; //сгенерував через чат gpt
                copy.transform.position = new Vector3(200 * i, 200 * j, 0);
            }
        }

    }
}
