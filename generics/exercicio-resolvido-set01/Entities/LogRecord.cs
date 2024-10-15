using System;


namespace exercicio_resolvido_set01
{
    class LogRecord 
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }


        public override bool Equals(object obj) {
            if (!(obj is LogRecord)) {
                return false;
            }
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }

    }
}