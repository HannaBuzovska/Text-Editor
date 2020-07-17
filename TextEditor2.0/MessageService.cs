using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace TextEditor2._0
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string exclamatin);
        void ShowError(string error);
    }
    public class MessageService: IMessageService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclatation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void IMessageService.ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        void IMessageService.ShowExclamation(string exclamatin)
        {
            throw new NotImplementedException();
        }

        void IMessageService.ShowError(string error)
        {
            throw new NotImplementedException();
        }
    }
}
