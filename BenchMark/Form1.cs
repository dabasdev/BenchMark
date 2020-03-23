using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BenchMark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNet_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();

            using (var db = new DalNet.Models.BenchModel())
            {
                sw.Start();

                var source =
                    db.Employees.AsNoTracking().ToList();

                lblCountNet.Text = source
                    .Count()
                    .ToString();

                sw.Stop();

                TxtNet.Text = sw.ElapsedMilliseconds.ToString();
            }
        }

        private void BtnCore_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();

            using (var db = new DalCore.Models.BenchMarkDbContext())
            {
                sw.Start();

                var source =
                    db.Employee.AsNoTracking().ToList();

                lblCountCore.Text = source
                    .Count()
                    .ToString();

                sw.Stop();

                TxtCore.Text = sw.ElapsedMilliseconds.ToString();
            }
        }
    }
}
