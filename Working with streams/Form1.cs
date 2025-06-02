namespace Working_with_streams
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
            op.ShowDialog();

            System.IO.FileStream f = new System.IO.FileStream(op.FileName,FileMode.Append,System.IO.FileAccess.ReadWrite);
            System.IO.StreamReader s = new System.IO.StreamReader(op.FileName);
            
        }
    }
}
