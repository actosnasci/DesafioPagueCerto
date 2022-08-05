using System;

namespace ApiPagueCerto.Models
{
    public class Transaction
    {
        
        public int NSU { get; set; }
        DateTime DateTransaction { get; set; }
        DateTime DateApproval { get; set; }
        DateTime DateDisapproval { get; set; }
        bool Antecipated { get; set; }
        string? AcquirerConfirmation { get; set; } 
        float InitialValue { get; set; }
        float FinalValue { get; set; }
        float Rate { get; set; }
        int Installment { get; set; }
        string? LastCardNumbers { get; set; }


    }
}