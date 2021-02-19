using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChessField;
using FigureNamespace;
public class SpawnFigures : MonoBehaviour {
    public GameObject[] piece;
    private void Start() {
        Figure figure = new Figure();
        Instantiate(piece[0]);
        if (figure.color == ColorOfFigure.Black) {
            switch(figure.typeOfFigure) {
                case TypeOfFigure.King:
                    figure.transform.position = new Vector2(transform.position.x - 4, transform.position.y - 5);
                    break;
            }
        }
    }
}
