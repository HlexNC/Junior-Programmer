using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChessField;
enum NameOfField : byte {
    a,
    b,
    c,
    d,
    e,
    f,
    g,
    h
}
public class ChessTable : MonoBehaviour {
    [SerializeField] private Field Whitefield;
    [SerializeField] private Field Blackfield;
    [SerializeField] private int size = 8;
    private Field[,] fields;
    private void Start() {
        fields = new Field[size , size];
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++) {
                if ((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0)) {
                    fields[i, j] = Instantiate(Whitefield);
                    Whitefield.transform.position = new Vector2(transform.position.x + i - 4, transform.position.y + j - 4);
                }
                else {
                    fields[i, j] = Instantiate(Blackfield);
                    Blackfield.transform.position = new Vector2(transform.position.x + i - 4, transform.position.y + j - 4);
                }
            }
        }
    }
}
