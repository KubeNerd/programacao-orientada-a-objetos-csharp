using System;
using System.Collections.Generic;


namespace exercicio_proposto.Entities.Exceptions
{
    class DomainException: ApplicationException
    {
        public DomainException(string message): base(message) 
        {
        
        
        }

    }
}
