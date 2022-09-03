using System.Windows.Forms;

namespace System
{
    internal class FormClosingEventHandler
    {
        private Action<object, FormClosingEventArgs> btnSair_Click;

        public FormClosingEventHandler(Action<object, FormClosingEventArgs> btnSair_Click)
        {
            this.btnSair_Click = btnSair_Click;
        }
    }
}