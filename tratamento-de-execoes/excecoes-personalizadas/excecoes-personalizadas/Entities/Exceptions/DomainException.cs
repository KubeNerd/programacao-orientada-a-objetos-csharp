namespace excecoes_personalizadas.Entities.Exceptions
{
    class DomainException: ApplicationException
    {
        public DomainException(string message)
            : base(message)
        {
            
        }
    }
}
