// this class is to manage the tiles. we don't need to extend the regular unity classes



public enum Sides
{
    Bottom,
    Right,
    Left,
    Top
}

public class Tile
{
    public int id = 0;
    public Tile[] neighbors = new Tile[4];

}