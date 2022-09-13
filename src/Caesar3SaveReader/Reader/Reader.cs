namespace Caesar3SaveReader.Reader
{
    public class SaveReader
    {
        public int[] ReadFile(string file)
        {
            using var stream = new FileStream(file, FileMode.Open);
            using var reader = new BinaryReader(stream);

            return ReadTerrainData(reader);
        }

        private int[] ReadTerrainData(BinaryReader input)
        {
            input.BaseStream.Seek(8, SeekOrigin.Current); // 2x integer

            input.SkipCompressedChunk(); // image grid
            input.SkipCompressedChunk(); // edge grid
            input.SkipCompressedChunk(); // building id grid

            return input.ReadCompressedChunk(decompressionStream =>
            {
                var decompressionStreamReader = new BinaryReader(decompressionStream);

                int[] data = new int[TerrainConstants.GRID_SIZE * TerrainConstants.GRID_SIZE];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = decompressionStreamReader.ReadUInt16();
                }
                return data;
            });
        }
    }
}
