using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Account
    {
        string name;
        int num;
        double summ;
        public Account()
        {
            SetName("");
            SetNum(0);
            SetSumm(0.0);

        }
        public Account(string name, int num, double summ)
        {
            SetName(name);
            SetNum(num);
            SetSumm(summ);
        }
        public void SetNum(int Num)
        {
            this.num = Num;
        }
        public void SetName(string Name)
        {
            this.name = Name;
        }
        public void SetSumm(double Summ)
        {
            this.summ = Summ;
        }

        public int GetCourse()
        {
            return this.num;

        }
        public string Getname()
        {
            return this.name;

        }
        public double GetSex()
        {
            return this.summ;

        }
    }
}
