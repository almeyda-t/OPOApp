﻿using System;
using System.Collections.Generic;

namespace OPOService.Models
{
    public partial class User
    {
        public User()
        {
            Bills = new HashSet<Bill>();
            Saldos = new HashSet<Saldo>();
            Transactions = new HashSet<Transaction>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsVerified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Saldo> Saldos { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
