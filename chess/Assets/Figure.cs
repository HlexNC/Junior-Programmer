using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChessField;
namespace FigureNamespace {
    public enum TypeOfFigure : byte {
        King,
        Queen,
        Bishop,
        Horse,
        Pawn
    }
    public enum ColorOfFigure : byte {
        White,
        Black
    }
    public class Figure : MonoBehaviour {
        public TypeOfFigure typeOfFigure;
        public ColorOfFigure color;
    }
}
