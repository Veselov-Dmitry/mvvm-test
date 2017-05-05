using MVVMTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace MVVMTest.ViewModel
{
    class MainViewModel
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public MainViewModel()
        {
            ClickCommand = new Command( arg => ClickMethod( ) );

            People = new PeopleModel {
                FirstName = "First name" ,
                LastName = "Last name"
            };
        }

        #endregion


        #region Properties

        /// <summary>
        /// Get or set people.
        /// </summary>
        public PeopleModel People
        {
            get; set;
        }

        #endregion


        #region Commands

        /// <summary>
        /// Get or set ClickCommand.
        /// </summary>
        public ICommand ClickCommand
        {
            get; set;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Click method.
        /// </summary>
        private void ClickMethod()
        {
            MessageBox.Show( "This is click command." );
        }

        #endregion
    }
}
