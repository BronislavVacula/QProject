using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using QProject.Base.DatabaseConnection;
using QProject.Classes;
using QProject.Classes.DocumentManager;
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
        /// <summary>
        /// The menu items
        /// </summary>
        private readonly List<MenuItem> menuItems = new();
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
            InitMenuItems();
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

        /// <summary>
        /// Initializes the menu items.
        /// </summary>
        /// <returns></returns>
        private void InitMenuItems()
        {

        }
        #endregion

        #region Methods
        #endregion

        #region Event handlers        
        /// <summary>
        /// Handles the Click event of the RibbonItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void RibbonItem_Click(object sender, EventArgs e)
        {
            if(sender is BarButtonItem barButtonItem && barButtonItem.Tag is MenuItem menuItem)
            {
                menuItem.Open();
            }
        }
        #endregion
    }
}