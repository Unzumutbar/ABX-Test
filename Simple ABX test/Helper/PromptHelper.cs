using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_ABX_test.Helper
{
    public static class PromptHelper
    {
        public static string ShowPasswordDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 265;
            prompt.Height = 125;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 25, Top = 10, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 25, Top = 25, Width = 200, UseSystemPasswordChar = true};
            Button confirmation = new Button() { Text = "Ok", Left = 125, Width = 100, Top = 55 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            return textBox.Text;
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 265;
            prompt.Height = 125;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 25, Top = 10, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 25, Top = 25, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 125, Width = 100, Top = 55 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.ShowDialog();
            return textBox.Text;
        }
    }
}
