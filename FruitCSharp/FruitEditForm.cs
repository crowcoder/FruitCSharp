using FruitCSharp.Context;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace FruitCSharp
{
    public partial class FruitEditForm : Form
    {
        //This is the Entity Framework data context.
        FruitContext ctx = new FruitContext();

        public FruitEditForm()
        {
            InitializeComponent();

            //Build our grid manually for educational purposes. Would usually
            //use the designer to do this.
            GridSetup();

            //Set our DataDirecty to the project's output location so the 
            // ConnectionString in app.config connection will expand it correctly.
            AppDomain.CurrentDomain.SetData("DataDirectory", 
                AppDomain.CurrentDomain.BaseDirectory);
        }

        private void LoadDataFromDatabase()
        {
            //Loads all data into the context so it is available locally
            ctx.FruitDbSet.Load();
            ctx.GrowsOnDbSet.Load();

            //Wraps data in magic that allows data to stay in sync with the
            //edits we do in the grid.
            BindingSource fruitBindingSrc = new BindingSource();
            var fruits = ctx.FruitDbSet.Local.ToBindingList<Models.Fruit>();
            fruitBindingSrc.DataSource = fruits;

            fruits.AllowEdit = true;
            fruits.AllowNew = true;
            fruits.AllowRemove = true;

            dataGridViewFruit.DataSource = fruitBindingSrc;
        }
        
        private void FruitEditForm_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        /// <summary>
        /// This constructs our grid columns the way we want them.We could use
        /// the Autogenerate columns feature but we don't really want to show
        /// the IDs and it will not create the dropdown column for us.
        /// Typically you would probably use the designer to build the columns,
        /// but it is easier to see what is going on this way than to dig through
        /// the generated code that the designer creates.
        /// </summary>
        private void GridSetup()
        {
            dataGridViewFruit.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColFruitName = new DataGridViewTextBoxColumn();
            //DataPropertyName binds the grid column to the data. This should be the same
            //name as your class property and database table column name (assuming you
            //are following convention)
            ColFruitName.DataPropertyName = "FruitName";

            //Header text is anything you'd like
            ColFruitName.HeaderText = "Fruit Name";

            //Specifies how to determine the width of the column. This sets it's
            //width to as wide as the longest data entry.
            ColFruitName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //FruitColor Column
            DataGridViewTextBoxColumn ColFruitColor = new DataGridViewTextBoxColumn();
            ColFruitColor.DataPropertyName = "FruitColor";
            ColFruitColor.HeaderText = "Color";
            ColFruitColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Fruit is yummy
            DataGridViewCheckBoxColumn ColFruitIsYummy = new DataGridViewCheckBoxColumn();
            ColFruitIsYummy.HeaderText = "Is Yummy?";
            ColFruitIsYummy.DataPropertyName = "FruitIsYummy";
            ColFruitIsYummy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //COMBOBOX: FruitGrowsOn column
            DataGridViewComboBoxColumn ColFruitGrowsOn = new DataGridViewComboBoxColumn();
            ColFruitGrowsOn.HeaderText = "Grows On";
            ColFruitGrowsOn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //This is the property on the Fruit class that holds the Grows On Id of that fruit.
            ColFruitGrowsOn.DataPropertyName = "FruitGrowsOn";
            
            //This is the string property on the GrowsOn class that holds the friendly name.
            ColFruitGrowsOn.DisplayMember = "GrowsOnName";
            
            //The int property on the GrowsOn class that is the primary key of the GrowsOn table.
            ColFruitGrowsOn.ValueMember = "Id";
            
            //Finally, the data to bind in the combobox. We already loaded all
            //data into our context, we basically have the whole database in memory now.
            ColFruitGrowsOn.DataSource = ctx.GrowsOnDbSet.Local;
            

            //We must now add the columns to the grid
            dataGridViewFruit.Columns.Add(ColFruitName);
            dataGridViewFruit.Columns.Add(ColFruitColor);
            dataGridViewFruit.Columns.Add(ColFruitIsYummy);
            dataGridViewFruit.Columns.Add(ColFruitGrowsOn);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
