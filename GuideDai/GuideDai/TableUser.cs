using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuideDai.Models;

namespace GuideDai
{
    public partial class TableUser : Form
    {
        Database datab;
        public TableUser(Database d)//форма з користувачами
        {
            InitializeComponent();
            datab = d;
            employeesBindingSource.DataSource = datab.Employees;
        }
    }
}
