using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAsyncApp.Services;

namespace WinFormsAsyncApp
{
    public partial class WelcomeForm : Form

    {
        private PrintService _printService;
        public WelcomeForm()
        {
            InitializeComponent();
            _printService = new PrintService();
        }

        private void btnMyHelloClick_Handler(object sender, EventArgs e)
        {
            MessageBox.Show("Event Handler");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            _printService.Print();
        }

        private void PrintViaThreadClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaThread();
            MessageBox.Show("thread method completed");
        }

        private void btnViaTaskClick_Handler(object sender, EventArgs e)
        {
            _printService.PrintViaTask();
            MessageBox.Show("Task Completed");
        }

        private async void btnViaTaskButAwait_Click(object sender, EventArgs e)
        {
            await _printService.PrintViaTaskAwaitable();
            MessageBox.Show("Awitable Task Completed");
        }

        private async void btnAwaitWithResult_Click(object sender, EventArgs e)
        {
          string result = await _printService.PrintViaTaskAwaitableResult();
          MessageBox.Show("task completed after 10 second result is:" + result);
        }
    }
}
