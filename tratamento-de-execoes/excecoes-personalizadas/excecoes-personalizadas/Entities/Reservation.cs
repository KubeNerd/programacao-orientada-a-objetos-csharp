﻿using excecoes_personalizadas.Entities.Exceptions;
using System;
using System.Text;

namespace excecoes_personalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de check-out deve ser posterior à data de check-in.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }


        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("As datas de reserva devem ser futuras.");
            }

 
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de check-out deve ser posterior à data de check-in.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                   + RoomNumber
                   + ", check-in: "
                   + CheckIn.ToString("dd/MM/yyyy")
                   + ", check-out: "
                   + CheckOut.ToString("dd/MM/yyyy")
                   + ", "
                   + Duration()
                   + " night(s)";
        }
    }
}
