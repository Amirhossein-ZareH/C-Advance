namespace Encrypte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog(this);



            try
            {
                byte[] b = System.IO.File.ReadAllBytes(op.FileName);

                for (int i = 0; i < b.Length; i++)
                {
                    b[i]++;
                }
                System.IO.File.WriteAllBytes(op.FileName+"emc", b);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog(this);



            try
            {
                byte[] b = System.IO.File.ReadAllBytes(op.FileName);

                for (int i = 0; i < b.Length; i++)
                {
                    b[i]--;
                }
                System.IO.File.WriteAllBytes(op.FileName+ ".new", b);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

            }
        }
    }
}
