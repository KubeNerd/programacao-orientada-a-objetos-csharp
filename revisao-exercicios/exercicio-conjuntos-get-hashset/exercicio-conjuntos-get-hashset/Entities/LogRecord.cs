﻿using System;

namespace exercicio_conjuntos_get_hashset.Entities
{
    class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant {  get; set; }


        public LogRecord()
        {
        
        }

        public LogRecord(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }


        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }


        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }


            LogRecord other = obj as LogRecord;
            return UserName.Equals(other.UserName);


        }

    }
}
