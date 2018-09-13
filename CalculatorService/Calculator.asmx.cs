using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorService
{
    /// <summary>
    /// Summary description for Calculator
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculator : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double f1, double f2)
        {
            return f1 + f2;
        }
        [WebMethod]
        public double Subtract(double f1, double f2)
        {
            return f1 - f2;
        }
        [WebMethod]
        public double Divide(double f1, double f2)
        {
            return f1 / f2;
        }
        [WebMethod]
        public double Multiply(double f1, double f2)
        {
            return f1 * f2;
        }
        [WebMethod]
        public double SqrRoot(double f1)
        {
            return System.Math.Sqrt(f1);
        }
        [WebMethod]
        public double Halve(double f1)
        {
            return f1 / 2;
        }
        [WebMethod]
        public double Quarter(double f1)
        {
            return f1 / 4;
        }
    }
}
