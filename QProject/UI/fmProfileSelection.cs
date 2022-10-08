using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QProject.UI
{
    public partial class fmProfileSelection : XtraForm
    {
        #region Properties and fields
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="fmProfileSelection"/> class.
        /// </summary>
        public fmProfileSelection()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        #endregion

        #region Event handlers
        /// <summary>
        /// Handles the Click event of the btnAddProfile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAddProfile_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnConfirm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}