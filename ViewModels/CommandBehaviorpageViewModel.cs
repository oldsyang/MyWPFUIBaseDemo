using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using MyWPFUI.Controls;

namespace MyWPFUIBaseDemo.ViewModels
{
    public class CommandBehaviorpageViewModel : MyPropertyChanged
    {
        #region Property

        public ICommand MouseDownCommand { get; set; }

        #endregion

        #region Constructor

        public CommandBehaviorpageViewModel()
        {
            MouseDownCommand=new DelegateCommand<object>(MouseDownCommandClick);
        }



        #endregion

        #region Command Handlers
        private void MouseDownCommandClick(object obj)
        {
            var param = obj as string;
            if (param != null)
            {
                MessageBox.Show(param);
            }
        }
        #endregion

        #region Public

        #endregion

        #region Private

        #endregion
    }
}
