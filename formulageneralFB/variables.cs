using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulageneralFB
{
    class variables
    {
      public double id { get; set; }
        public string A { get; set; }
        public string B{ get; set; }
        public string C { get; set; }
        public string x1 { get; set; }
        public string x2 { get; set; }
        public string fecha { get; set; }

        double a, b, c, X1, X2;
        public Double getA() { return a; }
        public void setA(Double a) { this.a = a; }
        public Double getB() { return b; }
        public void setB(Double b) { this.b = b; }
        public Double getC() { return c; }
        public void setC(Double c) { this.c = c; }
        public Double getx1() { return X1; }
        public void setx1(Double X1) { this.X1 = X1; }
        public Double getx2() { return X2; }
        public void setx2(Double X2) { this.X2 = X2; }

    }
}
