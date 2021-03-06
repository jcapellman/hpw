﻿using System;

namespace hostinpanda.library.DAL.Tables
{
    public class BaseTable
    {
        public int ID { get; set; }

        public bool Active { get; set; }

        public DateTimeOffset Modified { get; set; }

        public DateTimeOffset Created { get; set; }
    }
}