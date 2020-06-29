// this class is to make the maps
// we will use 1D array to store the maps
// while 2D array is easier to represent, this makes the game consume more memory



public class Map
{
    public Tile[] tiles;
    public int columns; // will represent the width of our map
    public int rows; // will represent the height of our map

    public void NewMap(int width, int height)
    {
        columns = width;
        rows = height;
        
        tiles = new Tile[columns*rows];
    }
    
    
    //method to create the tiles
    private void CreateTiles()
    {
        
    }
    
}
