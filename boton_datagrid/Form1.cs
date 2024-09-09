using System.Collections;

namespace boton_datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Telefono";
            dataGridView1.Columns[3].Name = "Ciudad";

            ArrayList AL = new ArrayList();
            AL.Add("1");
            AL.Add("Leslie");
            AL.Add("33844230");
            AL.Add("Quito");
            dataGridView1.Rows.Add(AL.ToArray());

            AL = new ArrayList();
            AL.Add("2");
            AL.Add("Paola");
            AL.Add("9624795");
            AL.Add("Quito");
            dataGridView1.Rows.Add(AL.ToArray());

            AL = new ArrayList();
            AL.Add("3");
            AL.Add("Melanie");
            AL.Add("7753259");
            AL.Add("Ambato ");
            dataGridView1.Rows.Add(AL.ToArray());

            DataGridViewButtonColumn btn =new DataGridViewButtonColumn();
            btn.HeaderText = "Button";
            btn.Name = "buton";
            btn.Text = "Click me";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) 
            {
                MessageBox.Show("diste clic en la columna " + (e.RowIndex+1).ToString() );
            }
        }
    }
}