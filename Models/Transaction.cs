using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiPagueCerto.Models
{
    public class Transaction
    {
        [Key]
        public int NSU { get; set; }
        public DateTime DateTransaction { get; set; }
        public DateTime DateApproval { get; set; }
        public DateTime DateDisapproval { get; set; }
        public bool Antecipated { get; set; }
        public string? AcquirerConfirmation { get; set; } 
        public float InitialValue { get; set; }
        public float FinalValue { get; set; }
        public float Rate { get; set; }
        public int Installment { get; set; }
        public string? LastCardNumbers { get; set; }


    }
}