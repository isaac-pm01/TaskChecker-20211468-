namespace TaskChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // L�gica para guardar la nota
            string title = txtTitle.Text;
            string body = rtbBody.Text;
            // Guardar la nota en una lista, base de datos, etc.
            MessageBox.Show("Nota guardada correctamente.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // L�gica para editar la nota
            string title = txtTitle.Text;
            string body = rtbBody.Text;
            // Actualizar la nota existente
            MessageBox.Show("Nota editada correctamente.");
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = cmbFont.SelectedItem.ToString();
            rtbBody.Font = new Font(selectedFont, rtbBody.Font.Size);
        }

        private void numFontSize_ValueChanged(object sender, EventArgs e)
        {
            float newFontSize = (float)numFontSize.Value;

            Font newFont = new Font(rtbBody.Font.FontFamily, newFontSize, rtbBody.Font.Style);

            rtbBody.Font = newFont;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            
            using (ColorDialog colorPicker = new ColorDialog())
            {
                
                if (colorPicker.ShowDialog() == DialogResult.OK)
                {
          
                    rtbBody.ForeColor = colorPicker.Color;
                }
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            FontStyle newStyle;
            if (rtbBody.SelectionFont.Bold) 
            {
                newStyle = rtbBody.SelectionFont.Style & ~FontStyle.Bold; 
            }
            else 
            {
                newStyle = rtbBody.SelectionFont.Style | FontStyle.Bold; 
            }

            Font newFont = new Font(rtbBody.SelectionFont, newStyle);

            rtbBody.SelectionFont = newFont;
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            FontStyle newStyle;
            if (rtbBody.SelectionFont.Italic)  
            {
                newStyle = rtbBody.SelectionFont.Style & ~FontStyle.Italic; 
            }
            else  
            {
                newStyle = rtbBody.SelectionFont.Style | FontStyle.Italic;  
            }

            Font newFont = new Font(rtbBody.SelectionFont, newStyle);
            rtbBody.SelectionFont = newFont;
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            FontStyle newStyle;
            if (rtbBody.SelectionFont.Underline) 
            {
                newStyle = rtbBody.SelectionFont.Style & ~FontStyle.Underline; 
            }
            else 
            {
                newStyle = rtbBody.SelectionFont.Style | FontStyle.Underline; 
            }
            Font newFont = new Font(rtbBody.SelectionFont, newStyle);

            rtbBody.SelectionFont = newFont;
        }

        private void AddCategory(string categoryName)
        {
            tvCategories.Nodes.Add(categoryName);
        }


    }
}
