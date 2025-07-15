namespace RunWindows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(comboBox1.Text);
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Items.Add(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = ("Browse");

            ofd.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] s = System.IO.File.ReadAllLines(Application.StartupPath + "\\save");
            for (int i = 0; i < s.Length; i++)
            {
                comboBox1.Items.Add((string)s[i]);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] s = new string[comboBox1.Items.Count];
            for (int i = 0;i < comboBox1.Items.Count; i++)
                s[i] = comboBox1.Items[i].ToString();
            System.IO.File.WriteAllLines("save.txt",s);
        }
    }
}
