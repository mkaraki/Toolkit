using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit.View
{
    public partial class AskLineWithOK : Form
    {
        public AskLineWithOK(string title, string message, string defaultValue = "")
        {
            InitializeComponent();

            Text = title;
            lbl_message.Text = message;
            tbox_ans.Text = defaultValue;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string UserAnswer { get; private set; } = string.Empty;

        private void tbox_ans_TextChanged(object sender, EventArgs e)
        {
            UserAnswer = tbox_ans.Text;
        }
    }
}
