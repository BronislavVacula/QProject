using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using QProject.Base;
using QProject.Base.Attributes;
using QProject.Templates.Controls;
using QProject.Templates.Interfaces;
using Shared.Extensions;

namespace QProject.Classes
{
    public class DocumentManagerEx
    {
        #region Singleton
        /// <summary>
        /// The instance
        /// </summary>
        private static DocumentManagerEx? instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static DocumentManagerEx Instance
        {
            get => instance ??= new DocumentManagerEx();
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="DocumentManagerEx"/> class from being created.
        /// </summary>
        private DocumentManagerEx() { }
        #endregion

        #region Constants        
        /// <summary>
        /// The node default name
        /// </summary>
        private const string nodeDefaultName = "Default name";
        #endregion

        #region Properties and fields        
        /// <summary>
        /// The accordion control
        /// </summary>
        private AccordionControl? _accordionControl;

        /// <summary>
        /// The tabbed view
        /// </summary>
        private TabbedView? _tabbedView;
        #endregion

        #region Methods   
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Init(AccordionControl accordionControl, TabbedView tabbedView)
        {
            _accordionControl = accordionControl;
            _tabbedView = tabbedView;
        }

        /// <summary>Opens the document.</summary>
        public void OpenDocument<DocumentType>(params object[] constructorParameters) where DocumentType : UserControl
        {
            OpenDocument(typeof(DocumentType), constructorParameters);
        }

        /// <summary>
        /// Opens the document 
        /// </summary>
        /// <param name="documentType"></param>
        public void OpenDocument(Type documentType, params object[] constructorParameters)
        {
            if (_tabbedView == null)
                return;

            UserControl? openedDocument = GetOpenedDocument(documentType, constructorParameters);
            DocumentAttribute? documentAttribute = documentType.GetAttribute<DocumentAttribute>();

            if (openedDocument == null)
            {
                openedDocument = (UserControl?)Activator.CreateInstance(documentType, constructorParameters);

                if (openedDocument != null)
                {
                    openedDocument.Tag = constructorParameters;

                    AccordionControlElement? groupElement = GetOrCreateGroupAccordionElement(documentAttribute?.GroupName ?? nodeDefaultName);

                    if (groupElement != null)
                    {
                        string documentCaption = openedDocument.ToString();

                        if(openedDocument is not ucTemplateDetail 
                            && documentAttribute != null
                            && !string.IsNullOrEmpty(documentAttribute.DocumentName))
                        {
                            documentCaption = documentAttribute.DocumentName;
                        }

                        CreateGroupItemAccordionElement(groupElement, openedDocument, documentCaption);

                        _tabbedView.AddDocument(openedDocument, documentCaption);
                        _tabbedView.ActivateDocument(openedDocument);
                    }
                }
            }
            else
            {
                _tabbedView.ActivateDocument(openedDocument);
            }
        }

        /// <summary>
        /// Gets the opened document.
        /// </summary>
        /// <param name="documentType">Type of the document.</param>
        /// <param name="constructorParameters">The constructor parameters.</param>
        /// <returns></returns>
        public UserControl? GetOpenedDocument(Type documentType, params object[] constructorParameters)
        {
            if (_tabbedView != null && _tabbedView.Documents != null)
            {
                foreach (BaseDocument document in _tabbedView.Documents)
                {
                    if (document.Control.GetType() == documentType)
                    {
                        if (document.Control.Tag == null && constructorParameters == null)
                            return document.Control as UserControl;

                        if (document.Control.Tag is object[] documentParams)
                        {
                            if (documentParams.Length == constructorParameters.Length && AreConstructorsSame(documentParams, constructorParameters))
                            {
                                return document.Control as UserControl;
                            }
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Are the constructors same.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        private bool AreConstructorsSame(object[] first, object[] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] is Entity documentEntity && second[i] is Entity newEntity)
                {
                    if (documentEntity.GetType() != newEntity.GetType() || documentEntity.Id != newEntity.Id)
                    {
                        return false;
                    }
                }
                else if (first[i] != second[i])
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether this instance [can close document] the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <returns>
        ///   <c>true</c> if this instance [can close document] the specified document; otherwise, <c>false</c>.
        /// </returns>
        public bool CanCloseDocument(UserControl document)
        {
            if (document is ITemplate template)
            {
                return template.CanFinish();
            }

            return true;
        }

        /// <summary>Closes the document.</summary>
        /// <param name="document"></param>
        /// <param name="removeDocument"></param>
        public void CloseDocument(UserControl document, bool removeDocument = true)
        {
            if (document != null)
            {
                OnDocumentClosing(document);

                if (removeDocument && _tabbedView != null)
                    _tabbedView.RemoveDocument(document);

                document.Dispose();
            }
        }

        /// <summary>
        /// Creates the group accordion element.
        /// </summary>
        private AccordionControlElement? GetOrCreateGroupAccordionElement(string groupName)
        {
            if (_accordionControl != null)
            {
                foreach (AccordionControlElement element in _accordionControl.Elements)
                {
                    if (element.Text == groupName)
                        return element;
                }

                AccordionControlElement newGroupElement = _accordionControl.AddGroup();
                newGroupElement.Text = groupName;

                return newGroupElement;
            }

            return null;
        }

        /// <summary>
        /// Creates the group item accordion element.
        /// </summary>
        private void CreateGroupItemAccordionElement(AccordionControlElement parentElement, UserControl document, string documentCaption)
        {
            AccordionControlElement newItemElement = parentElement.Elements.Add();
            newItemElement.Text = documentCaption;
            newItemElement.Style = ElementStyle.Item;
            newItemElement.Tag = document;

            parentElement.Expanded = true;
        }

        /// <summary>
        /// Deletes the group item accordion element.
        /// </summary>
        private void DeleteGroupItemAccordionElement(UserControl document)
        {
            if (_accordionControl != null)
            {
                DocumentAttribute? documentAttribute = document.GetType().GetAttribute<DocumentAttribute>();
                AccordionControlElement? groupElement = GetAccordionElementBySelector(_accordionControl.Elements, e => e.Text == (documentAttribute?.GroupName ?? nodeDefaultName));

                if (groupElement != null)
                {
                    AccordionControlElement? itemElement = GetAccordionElementBySelector(groupElement.Elements, e => e.Tag.Equals(document));

                    if (itemElement != null)
                    {
                        groupElement.Elements.Remove(itemElement);

                        if (groupElement.Elements.Count == 0)
                        {
                            _accordionControl.Elements.Remove(groupElement);
                        }
                    }
                }
            }
        }

        /// <summary>Gets the accordion element by selector.</summary>
        /// <param name="parentCollection">The parent collection.</param>
        /// <param name="selector">The selector.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        private AccordionControlElement? GetAccordionElementBySelector(AccordionControlElementCollection parentCollection, Func<AccordionControlElement, bool> selector)
        {
            foreach (AccordionControlElement element in parentCollection)
            {
                if (selector(element))
                {
                    return element;
                }
            }

            return null;
        }
        #endregion

        #region Event handlers
        /// <summary>
        /// Document is closing
        /// </summary>
        /// <param name="document"></param>
        public void OnDocumentClosing(UserControl document)
        {
            DeleteGroupItemAccordionElement(document);
        }
        #endregion
    }
}
