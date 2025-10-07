using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Server.GUI
{
    public class TextBoxWriter : TextWriter
    {
        private readonly TextBox _textBox;

        public TextBoxWriter(TextBox textBox)
        {
            _textBox = textBox;
        }

        public override void Write(char value)
        {
            AppendText(value.ToString());
        }

        public override void Write(string value)
        {
            AppendText(value);
        }

        public override void WriteLine(string value)
        {
            AppendText(value + Environment.NewLine);
        }

        private void AppendText(string text)
        {
            if (_textBox.InvokeRequired)
            {
                _textBox.Invoke((Action)(() => _textBox.AppendText(text)));
            }
            else
            {
                _textBox.AppendText(text);
            }
        }

        public override Encoding Encoding => Encoding.UTF8;
    }
}
