using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace QProject.UI
{
    public partial class fmProfileDetail : XtraForm
    {
        #region Properties and fields
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="fmProfileDetail"/> class.
        /// </summary>
        public fmProfileDetail()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Validates the content.
        /// </summary>
        /// <returns></returns>
        private bool ValidateContent()
        {
            bool result = true;
            return result;
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// Handles the Click event of the btnConfirm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(ValidateContent())
            {
                DialogResult = DialogResult.OK;
            }
        }
        #endregion
    }
}