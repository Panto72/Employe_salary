using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_salary
{
    internal class Employe:Person
    {
        public string Designation {  get; set; }
        public string Branch { get; set; }
        public int Basic { get; set; }    
        public int Insentive { get; set; }    
        public int TA {  get; set; }
        public int PF {  get; set; }
        public int Total_salary {  get; set; }

        //public Employe() { }
        public double Salary()
        {
            
            Insentive =(int) (Basic * 0.5);
            TA = (int)(Basic * 0.2);
            PF = (int) (Basic * 0.4);
            Total_salary = Basic + Insentive + TA-PF;
            return Total_salary;
        }
    }
}
