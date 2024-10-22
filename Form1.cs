using System.Data;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dgvEstados.Rows.Add("Q0");
            this.dgvEstados.Rows.Add("Q1");
            this.dgvEstados.Rows.Add("Q2");
            this.dgvEstados.Rows.Add("Q3");
            this.dgvEstados.Rows.Add("Q4");
            this.dgvEstados.Rows.Add("Q5");
            this.dgvEstados.Rows.Add("Q6");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            char[] arr = this.txtOracion.Text.ToCharArray();
            string resultado = "";
            DataGridViewRow row = this.dgvEstados.Rows[0];
            for (int i = 0; i < this.txtOracion.TextLength; i++)
            {
                if (arr[0] == '*')
                {
                    if (row.Cells["asterisco"].Value != null) {
                        if (row.Cells["asterisco"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["asterisco"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            arr = arr.Where(n => n != arr[0]).ToArray();
                            if (arr.Length > 0)
                            {
                                row = this.dgvEstados.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["fdc"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["fdc"].Value.ToString();
                                }
                            }
                        }
                        else if (arr.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (arr[0] == '+')
                {
                    if (row.Cells["mas"].Value != null)
                    {
                        if (row.Cells["mas"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["mas"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            arr = arr.Where(n => n != arr[0]).ToArray();
                            if (arr.Length > 0)
                            {
                                row = this.dgvEstados.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["fdc"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["fdc"].Value.ToString();
                                }
                            }
                        }
                        else if (arr.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (arr[0] == '/')
                {
                    if (row.Cells["diagonal"].Value != null)
                    {
                        if (row.Cells["diagonal"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["diagonal"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            arr = arr.Where(n => n != arr[0]).ToArray();
                            if (arr.Length > 0)
                            {
                                row = this.dgvEstados.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["fdc"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["fdc"].Value.ToString();
                                }
                            }
                        }
                        else if (arr.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (arr[0] == '^')
                {
                    if (row.Cells["potencia"].Value != null)
                    {
                        if (row.Cells["potencia"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["potencia"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            arr = arr.Where(n => n != arr[0]).ToArray();
                            if (arr.Length > 0)
                            {
                                row = this.dgvEstados.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["fdc"].Value == null)
                                {
                                    resultado = "Error";
                                } else
                                {
                                    resultado = row.Cells["fdc"].Value.ToString();
                                }
                            }
                        }
                        else if (arr.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else if (Int32.Parse(arr[0].ToString()) >= 0 && Int32.Parse(arr[0].ToString()) <= 9)
                {
                    if (row.Cells["digitos"].Value != null)
                    {
                        if (row.Cells["digitos"].Value.ToString().Substring(0, 1) == "Q")
                        {
                            char[] c = row.Cells["digitos"].Value.ToString().ToCharArray();
                            int punto = Int32.Parse(c[1].ToString());
                            arr = arr.Where(n => n != arr[0]).ToArray();
                            if (arr.Length > 0)
                            {
                                row = this.dgvEstados.Rows[punto];
                            }
                            else
                            {
                                if (row.Cells["fdc"].Value == null)
                                {
                                    resultado = "Error";
                                }
                                else
                                {
                                    resultado = row.Cells["fdc"].Value.ToString();
                                }
                            }
                        } else if (arr.Length == 1)
                        {
                            resultado = "Error";
                        }
                    }
                    else
                    {
                        resultado = "Error";
                    }
                }
                else
                {
                    if (row.Cells["fdc"].Value == null)
                    {
                        resultado = "Error";
                    }
                    else
                    {
                        resultado = row.Cells["fdc"].Value.ToString();
                    }
                }

                if (resultado != "")
                {
                    if (resultado == "Aceptado")
                    {
                        MessageBox.Show("La cadena es valida");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("La cadena es invalida");
                        break;
                    }
                }
            }
        }
    }
}
