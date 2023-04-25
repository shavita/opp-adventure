namespace OOPAdventure
{
    public interface IAction
    {
        string Name { get; }

        void Execute(string[] args);
    }
}