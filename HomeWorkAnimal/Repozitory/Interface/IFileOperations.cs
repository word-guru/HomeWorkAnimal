namespace HomeWorkAnimal.Repozitory.Interface
{
    public interface IFileOperations
    {
        void SaveFile(string text);
        Dictionary<string, string> LoadFile();
    }
}
