using ConsumerApp.ConvertService;
using ConsumerApp.FibonacciService;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsumerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void BtnConvertXmlToJson_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = await ConvertXmlToJsonAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("le serveur ne répond pas!");
                Console.WriteLine(ex.ToString());
            }
        }
        private async Task<string> ConvertXmlToJsonAsync()
        {
            XmlObject xx = new XmlObject() { xmlData = textBox2.Text };
            Application.DoEvents();
            ConvertController convertService = new ConvertController();
            return await Task.FromResult(convertService.XmlToJson(xx));
        }

        private async Task<string> CalcFibonacciAsync()
        {
            decimal? result = null;
            await Task.Delay(1);
            Application.DoEvents();
            FibonacciController fibonacciService = new FibonacciController();
            result = fibonacciService.Fibonacci(int.Parse(textBox1.Text));
            return (result == null ? "" : result.ToString());
        }

        private async void BtnGetFibonacciData_Click(object sender, EventArgs e)
        {
            var progressForm = new Form2();
            try
            {
                var progressFormTask = progressForm.ShowDialogAsync();
                var data = await CalcFibonacciAsync();
                progressForm.Close();
                await progressFormTask;
                MessageBox.Show(data.ToString());
            }
            catch(Exception ex)
            {
                progressForm.Close();
                MessageBox.Show("le serveur ne répond pas!");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
