﻿namespace expenseTracker.Model
{
    public class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public float ExchangeRate { get; set; }

    }
}
