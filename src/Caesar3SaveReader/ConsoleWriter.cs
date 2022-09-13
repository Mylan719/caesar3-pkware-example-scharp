using Caesar3SaveReader.Reader;

namespace Caesar3SaveReader
{
    public class ConsoleWriter
    {
        public static void PrintTerrain(int[] terrainGrid)
        {
            for (int y = 0; y < TerrainConstants.GRID_SIZE; y++)
            {
                bool hasTerrain = false;
                for (int x = 0; x < TerrainConstants.GRID_SIZE; x++)
                {
                    int terrain = terrainGrid[y * TerrainConstants.GRID_SIZE + x];
                    char symbol;
                    if ((terrain & TerrainConstants.TERRAIN_OUTSIDE_MAP) == TerrainConstants.TERRAIN_OUTSIDE_MAP)
                    {
                        symbol = '\0';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_TREE) > 0)
                    {
                        symbol = 'Y';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_ROCK) > 0)
                    {
                        symbol = 'O';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_WATER) > 0)
                    {
                        symbol = '~';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_BUILDING) > 0)
                    {
                        symbol = 'B';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_SCRUB) > 0)
                    {
                        symbol = 'v';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_GARDEN) > 0)
                    {
                        symbol = 'z';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_ROAD) > 0)
                    {
                        symbol = '=';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_AQUEDUCT) > 0)
                    {
                        symbol = '|';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_ELEVATION) > 0)
                    {
                        symbol = '/';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_ACCESS_RAMP) > 0)
                    {
                        symbol = '\\';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_WALL) > 0)
                    {
                        symbol = 'w';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_GATEHOUSE) > 0)
                    {
                        symbol = 'W';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_MEADOW) > 0)
                    {
                        symbol = '_';
                    }
                    else if ((terrain & TerrainConstants.TERRAIN_RUBBLE) > 0)
                    {
                        symbol = ';';
                    }
                    else
                    {
                        symbol = '.';
                    }
                    if (symbol > 0)
                    {
                        Console.Write(symbol);
                        hasTerrain = true;
                    }
                }
                if (hasTerrain)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
