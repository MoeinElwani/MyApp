﻿using System;
using System.Collections.Generic;

namespace Vue2Spa.Models.DB
{
    public partial class CusReceipts
    {
        public int ReceiptId { get; set; }
        public int CusId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public float Amount { get; set; }
        public short OperId { get; set; }
        public string Note { get; set; }
        public byte SalesmanId { get; set; }
    }
}
