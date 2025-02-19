namespace WinFormsAsyncApp
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPrint = new Button();
            btnHello = new Button();
            btnViaThread = new Button();
            btnViaTask = new Button();
            btnViaTaskButAwait = new Button();
            btnAwaitWithResult = new Button();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(52, 61);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(188, 47);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnHello
            // 
            btnHello.Location = new Point(451, 61);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(202, 47);
            btnHello.TabIndex = 1;
            btnHello.Text = "Hello";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnMyHelloClick_Handler;
            // 
            // btnViaThread
            // 
            btnViaThread.Location = new Point(52, 125);
            btnViaThread.Name = "btnViaThread";
            btnViaThread.Size = new Size(188, 47);
            btnViaThread.TabIndex = 2;
            btnViaThread.Text = "PrintViaThread";
            btnViaThread.UseVisualStyleBackColor = true;
            btnViaThread.Click += PrintViaThreadClick_Handler;
            // 
            // btnViaTask
            // 
            btnViaTask.Location = new Point(52, 193);
            btnViaTask.Name = "btnViaTask";
            btnViaTask.Size = new Size(188, 47);
            btnViaTask.TabIndex = 3;
            btnViaTask.Text = "PrintViaTask";
            btnViaTask.UseVisualStyleBackColor = true;
            btnViaTask.Click += btnViaTaskClick_Handler;
            // 
            // btnViaTaskButAwait
            // 
            btnViaTaskButAwait.Location = new Point(52, 260);
            btnViaTaskButAwait.Name = "btnViaTaskButAwait";
            btnViaTaskButAwait.Size = new Size(188, 47);
            btnViaTaskButAwait.TabIndex = 4;
            btnViaTaskButAwait.Text = "PrintViaTaskButAwait";
            btnViaTaskButAwait.UseVisualStyleBackColor = true;
            btnViaTaskButAwait.Click += btnViaTaskButAwait_Click;
            // 
            // btnAwaitWithResult
            // 
            btnAwaitWithResult.Location = new Point(52, 313);
            btnAwaitWithResult.Name = "btnAwaitWithResult";
            btnAwaitWithResult.Size = new Size(188, 47);
            btnAwaitWithResult.TabIndex = 5;
            btnAwaitWithResult.Text = "PrintViaTaskButAwaitWithResults";
            btnAwaitWithResult.UseVisualStyleBackColor = true;
            btnAwaitWithResult.Click += btnAwaitWithResult_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAwaitWithResult);
            Controls.Add(btnViaTaskButAwait);
            Controls.Add(btnViaTask);
            Controls.Add(btnViaThread);
            Controls.Add(btnHello);
            Controls.Add(btnPrint);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrint;
        private Button btnHello;
        private Button btnViaThread;
        private Button btnViaTask;
        private Button btnViaTaskButAwait;
        private Button btnAwaitWithResult;
    }
}