using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QProject.Base.DatabaseConnection;
using QProject.Classes;
using QProject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace QProject
{
    public partial class fmMain : RibbonForm
    {
        #region Properties and fields
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="fmMain"/> class.
        /// </summary>
        public fmMain()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            InitProfileSelection();
            InitDatabaseConnection();
            InitDocumentManager();
        }

        /// <summary>
        /// Initializes the profile selection.
        /// </summary>
        private void InitProfileSelection()
        {
            using var profileSelectionDialog = new fmProfileSelection();

            profileSelectionDialog.ShowDialog();
        }

        /// <summary>
        /// Initializes the database connection.
        /// </summary>
        private void InitDatabaseConnection()
        {
            DBConn.Instance.Init("");
        }

        /// <summary>
        /// Initializes the document manager.
        /// </summary>
        private void InitDocumentManager()
        {
            DocumentManagerEx.Instance.Init(navigator, tabbedView1);
            DocumentManagerEx.Instance.OpenDocument(typeof(UI.Projects.ucProjectList));
        }
        #endregion

        #region Methods
        #endregion

        #region Event handlers
        #endregion
    }
}