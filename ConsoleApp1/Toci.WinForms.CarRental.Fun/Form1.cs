using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toci.CarRental.Dal.EF;

namespace Toci.WinForms.CarRental.Fun
{
    public partial class Form1 : Form
    {
        // DataModel
        carrentalEntities ent = new carrentalEntities();
        
        DbSet<driverslicensecategory> licences;//= DbSet<driverslicensecategory>();// DbSet<driverslicensecategory>();
        int topVariable = 20;

        public Form1()
        {
            ICollection<string> lic  = ent.driverslicensecategory.Select(x => x.name.ToString()).ToList();
            InitializeComponent();

            foreach (var item in lic)
            {
                Button b = AddButton(item, topVariable, 20);
                this.Controls.Add(b);
                topVariable += 20;
            }
        }
        private Button AddButton(string licence, int top,int left)
        {
            Button but = new Button();
            but.Text = licence;
            but.Top = top;
            but.Left= left;
            return but;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
