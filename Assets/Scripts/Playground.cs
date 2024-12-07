using UnityEngine;

public class Playground : SingletonMono<Playground>
{
    [Header("Grid Size")]
    public int width;
    public int height;

    private enum Cell
    {
        EMPTY = 0,
        PREVIEW = 1,
        FILL = 2,
    }
    private Cell[,] grid;

    protected override void Awake()
    {
        base.Awake();
        grid = new Cell[width, height];
    }
}
