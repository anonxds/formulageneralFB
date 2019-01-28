using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace formulageneralFB
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kHsT70sE7Q9hPkWFmhCFHxYGghrnUodOf9AG6B1W",
            BasePath = "https://formulageneral-5b180.firebaseio.com/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                dt.Columns.Add("fecha");
                dt.Columns.Add("A");
                dt.Columns.Add("B");
                dt.Columns.Add("C");
                dt.Columns.Add("x1");
                dt.Columns.Add("x2");
                dataGridView1.DataSource = dt;
                grid();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private async void btnresultado_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            counter get = resp.ResultAs<counter>();

            variables var = new variables();
            formula();
            var Variables = new variables
            {
                id = (Convert.ToInt32((get.cnt)+1)),
                fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                A = txta.Text,
                B = txtb.Text,
                C = txtc.Text,
                x1 = lblx1.Text,
                x2 = lblx2.Text
            
            };
            
               SetResponse response = await client.SetTaskAsync("Operaciones/" + Variables.id, Variables);
             variables result = response.ResultAs<variables>();
             MessageBox.Show("Inserto");

            var obj = new counter
            {
                cnt = Variables.id
            };

            SetResponse responses = await client.SetTaskAsync("Counter/node",obj);
            
        }
        public void formula()
        {
            double x1, x2;
            variables var = new variables();
            var.setA(Convert.ToDouble(txta.Text));
            var.setB(Convert.ToDouble(txtb.Text));
            var.setC(Convert.ToDouble(txtc.Text));
          x1 =  (-var.getB() + (Math.Sqrt(Math.Pow(var.getB(),2) - (4*var.getA()*var.getC()))) / (2* var.getA()));
            var.setx2(-var.getB() - (Math.Sqrt(Math.Pow(var.getB(), 2) - (4 * var.getA() * var.getC()))) / (2 * var.getA()));

            lblx1.Text = x1.ToString();
            lblx2.Text = var.getx2().ToString();


        }
        private async void grid()
        {
            dt.Rows.Clear();
            int i = 0;
            FirebaseResponse response = await client.GetTaskAsync("Counter/node");
            counter obj = response.ResultAs<counter>();
            int cnt = Convert.ToInt32(obj.cnt);
            while (true)
            {
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("Operaciones/" + i);
                    variables obj2 = resp2.ResultAs<variables>();

                    DataRow row = dt.NewRow();
                    row["fecha"] = obj2.fecha;
                    row["A"] = obj2.A;
                    row["B"] = obj2.B;
                    row["C"] = obj2.C;
       
       
                    row["x1"] = obj2.x1;
                    row["x2"] = obj2.x2;
                        dt.Rows.Add(row);





                }
                catch
                {

                }
            }
        }

        private  void btnrefresh_Click(object sender, EventArgs e)
        {
            grid();
            
            
        }
    }
}
