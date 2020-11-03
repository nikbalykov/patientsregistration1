using System;

namespace PatientsRegistration
{
    public class Record
    {
        public int Id { get; set; }

        public bool Marked { get; set; }

        public string Type { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public string Name { get; set; }

        public string DepartmentGroup { get; set; }

        public double BedCount { get; set; }

        public double Consisted { get; set; }

        public double Received { get; set; }

        public double Rural { get; set; }

        public double RelocatedFrom { get; set; }

        public double RelocatedTo { get; set; }

        public double Discharged { get; set; }

        public double Died { get; set; }

        public double Consist { get; set; }

        public double PlanKdn { get; set; }

        public double FactKdn { get; set; }

        public double RuralKdn { get; set; }

        public Record() { }
        public Record(bool marked, string type, int year, int month, string name, string departmentGroup) 
        {
            this.Marked = marked;
            this.Type = type;
            this.Year = year;
            this.Month = month;
            this.Name = name;
            this.DepartmentGroup = departmentGroup;
            this.BedCount = 0;
            this.Consisted = 0;
            this.Received = 0;
            this.Rural = 0;
            this.RelocatedFrom = 0;
            this.RelocatedTo = 0;
            this.Discharged = 0;
            this.Died = 0;
            this.Consist = 0;
            this.PlanKdn = 0;
            this.FactKdn = 0;
            this.RuralKdn = 0;
        }

        public double PlanPercent
        {
            get
            {
                if (PlanKdn == 0)
                    return 0;
                return Math.Round(FactKdn / PlanKdn * 100, 1);
            }
        }

        public double Mortality
        {
            get
            {
                if ((Died + Discharged) == 0 | (Died + RelocatedTo) == 0)
                    return 0;
                if (Type == "Отделение")
                {
                    return Math.Round(Died / (Died + Discharged), 1);
                }
                else
                {
                    return Math.Round(Died / (Died + RelocatedTo), 1);
                }
            }
        }

        public double AverageStay 
        {
            get
            {
                if ((Died + Discharged) == 0 | (Died + RelocatedTo) == 0)
                    return 0;
                if (Type == "Отделение")
                {
                    return Math.Round(FactKdn / (Died + Discharged), 1);
                }
                else
                {
                    return Math.Round(FactKdn / (Died + RelocatedTo), 1);
                }
            }
        }

        public double BedWork
        {
            get
            {
                if (BedCount == 0)
                    return 0;
                return Math.Round(FactKdn / BedCount, 1);
            }
        }

        public double BedTurnOver 
        {
            get
            {
                if (BedCount == 0)
                    return 0;
                if (Type == "Отделение")
                {
                    return Math.Round((Died + Discharged) / BedCount, 1);
                }
                else
                {
                    return Math.Round((Died + RelocatedTo) / BedCount, 1);
                }
            }
        }

        public double RuralPercent
        {
            get
            {
                if (Received == 0)
                    return 0;
                return Math.Round(Rural / Received * 100, 1);
            }
        }
    }
}
