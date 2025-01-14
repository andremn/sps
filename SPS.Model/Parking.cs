﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SPS.Model
{
    public class Parking
    {
        [Key]
        public virtual string CNPJ { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Collaborator> Collaborators { get; set; }

        public virtual Address Address { get; set; }

        public virtual int StreetNumber { get; set; }

        public virtual IList<ParkingSpace> Spaces { get; set; }

        public virtual IList<Price> Prices { get; set; }

        public virtual LocalManager LocalManager { get; set; }

        public virtual IList<Client> Clients { get; set; }
    }
}

