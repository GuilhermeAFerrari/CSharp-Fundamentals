namespace ExercicioConjuntos.Entities
{
    public class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
                return false;

            LogRecord logRecord = obj as LogRecord;
            return Username.Equals(logRecord.Username);
        }
    }
}
