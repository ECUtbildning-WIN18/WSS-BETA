namespace WSS
{
    class Prisoner
    {
        public string PrisonerId { get; private set; }
        public string Name { get; private set; }
        public bool IsAlive { get; private set; } = true;

        public Prisoner(string prisonerId, string name)
        {
            PrisonerId = prisonerId;
            Name = name;
        }
    }
}
