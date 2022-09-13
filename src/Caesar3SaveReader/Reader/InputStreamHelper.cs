namespace Caesar3SaveReader.Reader
{
    public static class BinaryReaderExtensions
    {
        public static T ReadCompressedChunk<T>(this BinaryReader reader, Func<Stream, T> readDataFunc)
        {
            int length = reader.ReadInt32();

            using var compressedInput = new PkwareInputStream(reader.BaseStream, length);

            return readDataFunc(compressedInput);
        }

        public static void SkipCompressedChunk(this BinaryReader reader)
        {
            int length = reader.ReadInt32();
            reader.BaseStream.Seek(length, SeekOrigin.Current);
        }
    }
}
