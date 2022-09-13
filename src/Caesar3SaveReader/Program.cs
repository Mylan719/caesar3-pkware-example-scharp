using Caesar3SaveReader;
using Caesar3SaveReader.Reader;

var saveReader = new SaveReader();
var terrain = saveReader.ReadFile("C:\\Path\\to\\Ceasar3\\Test.sav");

ConsoleWriter.PrintTerrain(terrain);
