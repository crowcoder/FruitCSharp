using FruitCSharp.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitCSharp
{
    public partial class FruitEditForm : Form
    {
        FruitContext ctx = new FruitContext();

        public FruitEditForm()
        {
            InitializeComponent();

            //Set our DataDirecty to the project's output location so the connection string in app.config
            //will expand it correctly.
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
        }

        private void LoadDataFromDatabase()
        {
            //Loads all data into the context so it is available locally
            ctx.FruitDbSet.Load();
            var fruits = ctx.FruitDbSet.Local.ToBindingList<Models.Fruit>();
            fruits.AllowEdit = true;
            fruits.AllowNew = true;
            fruits.AllowRemove = true;
            dataGridViewFruit.DataSource = fruits;
        }
        
        private void FruitEditForm_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
