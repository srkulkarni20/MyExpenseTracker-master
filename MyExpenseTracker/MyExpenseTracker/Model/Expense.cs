﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyExpenseTracker.Model
{
    public enum CategoryPicker

    {
        home,
        entertainment,
        food,
        auto,
        education,
        health
    };
    public class Expense
    {
        public int ID { get; set; }
        public string Details { get; set; }
        public CategoryPicker Category { get; set; }
        public double Spent { get; set; }
        public DateTime Date { get; set; }
    }
}
