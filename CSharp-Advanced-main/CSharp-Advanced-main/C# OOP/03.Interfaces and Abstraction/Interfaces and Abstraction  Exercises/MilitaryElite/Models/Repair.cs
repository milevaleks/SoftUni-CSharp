﻿using _MilitaryElite.Contracts;

namespace _MilitaryElite.Exeptions
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }
        public int HoursWorked { get; private set; }
        public override string ToString() =>
            $"  Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
    }
}
